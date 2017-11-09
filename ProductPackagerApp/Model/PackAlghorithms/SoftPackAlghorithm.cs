using System.Collections.Generic;
using ProductPackagerApp.Model.PackSteps;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public class SoftPackAlghorithm : PackAlghorithm
    {
        protected override List<IPackStep> PackSteps { get; } = new List<IPackStep>() {
            new PackStep("Поставить коробку на конвейер"),
            new PackStep("Поместить игрушкой в коробку"),
            new PackStep("Закрыть коробку"),
            new PackStep("Заклеить коробку скотчем "),
        };
    }
}
