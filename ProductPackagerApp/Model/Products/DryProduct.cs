using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackAlghorithms;

namespace ProductPackagerApp.Model.Products
{
    public class DryProduct : Product
    {
        public DryProduct(DryPackAlghorithm packAlg) : base(packAlg)
        {

        }
    }
}
