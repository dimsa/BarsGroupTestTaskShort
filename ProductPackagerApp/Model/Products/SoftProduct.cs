using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    public class SoftProduct : IProduct
    {
        private readonly IPackAlghorithm _packAlg;

        public SoftProduct(IPackAlghorithm packAlg)
        {
            _packAlg = packAlg;
        }
        public void Pack(ILogger logger)
        {
            _packAlg.WriteToLog(logger);        
        }
    }
}
