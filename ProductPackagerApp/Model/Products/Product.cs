using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    public class Product : IProduct
    {
        public Product(IPackAlghorithm packAlg)
        {
            PackAlg = packAlg;
        }

        protected IPackAlghorithm PackAlg { get; }

        public void Pack(ILogger logger)
        {
            PackAlg.WriteToLog(logger);
        }
    }
}
