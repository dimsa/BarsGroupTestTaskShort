using ProductPackagerApp.Loggers;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public interface IPackAlghorithm
    {
        void Execute(ILogger logger);        
    }
}
