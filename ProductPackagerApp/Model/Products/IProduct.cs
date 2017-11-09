using ProductPackagerApp.Loggers;

namespace ProductPackagerApp.Model.Products
{
   public interface IProduct
    {
        void Pack(ILogger logger);
    }
}
