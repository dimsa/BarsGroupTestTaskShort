using System.Collections.Generic;
using ProductPackagerApp.Loggers;
using ProductPackagerApp.Model.PackSteps;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public abstract class PackAlghorithm : IPackAlghorithm
    {
        protected abstract List<IPackStep> PackSteps { get; }
        public void Execute(ILogger logger)
        {
            foreach (var packStep in PackSteps)
            {
                // Если произойдет исключение при выполнении шага, то оно обработается выше
                packStep.Make();
                logger.Log(packStep.GetStepMessage());
            }
        }
    }
}
