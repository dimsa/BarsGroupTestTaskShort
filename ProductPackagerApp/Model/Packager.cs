using System;
using Castle.Windsor;
using ProductPackagerApp.Common;
using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.Products;

namespace ProductPackagerApp.model
{
    /* Вместо традиционного решения с фабриками, сделал вариант с IoC-контейнером
     * Т.е. получается, что какой алгоритм упаковки запросит продукт, такой и будет подтянут,
     * что соответсвует предсиловию задачи - применить неправильный алгоритм упаковки стало невозможно.
     * Алгоритмы и логеры создаются один раз, продукты каждый раз.
     */

    public class Packager
    {
        private readonly IWindsorContainer _container;
        private readonly InformDelegate Inform;
        public Packager(IWindsorContainer container, InformDelegate informDelegate)
        {
            _container = container;
            Inform = informDelegate;
        }

        public void Pack(char productType, char loggerType)
        {
            try
            {
                var logger = _container.Resolve<ILogger>(ElementNames.GetLoggerName(loggerType));
                var product = _container.Resolve<IProduct>(ElementNames.GetProductTypeName(productType));
                product.Pack(logger);
                ConfirmSuccess();
            }
            catch (Exception e)
            {                
                InformFail(e.Message);
            }
        }

        private void InformFail(string message)
        {
            Inform("Упаковка завершилась неудачей: " + message, ConsoleColor.Red);
        }

        private void ConfirmSuccess()
        {
            Inform("Упаковка успешна", ConsoleColor.Green);          
        }
    }
}
