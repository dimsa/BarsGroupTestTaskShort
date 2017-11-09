using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    public class SoftProduct : Product
    {
        public SoftProduct(SoftPackAlghorithm packAlg) : base(packAlg)
        {

        }
    }
}
