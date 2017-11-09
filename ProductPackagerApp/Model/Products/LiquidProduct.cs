using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    public class LiquidProduct : IProduct
    {
        private readonly IPackAlghorithm _packAlg;

        public LiquidProduct(IPackAlghorithm packAlg)
        {
            _packAlg = packAlg;
        }
        public void Pack(ILogger logger)
        {
            _packAlg.WriteToLog(logger);        
        }
    }
}
