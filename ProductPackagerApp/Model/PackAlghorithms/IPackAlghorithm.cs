using ProductPackagerApp.Loggers;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public interface IPackAlghorithm
    {
        void WriteToLog(ILogger logger);        
    }
}
