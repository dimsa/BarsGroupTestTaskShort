using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    /* Базовый продукт ничего не знает об алгоритме упаковки, кроме того, что он есть */
    public abstract class Product : IProduct
    {
        public Product(IPackAlghorithm packAlg)
        {
            PackAlg = packAlg;
        }

        protected IPackAlghorithm PackAlg { get; }

        public void Pack(ILogger logger)
        {
            PackAlg.Execute(logger);
        }
    }
}
