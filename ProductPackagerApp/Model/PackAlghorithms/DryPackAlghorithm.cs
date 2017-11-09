using System.Collections.Generic;
using ProductPackagerApp.Model.PackSteps;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public class DryPackAlghorithm : PackAlghorithm
    {
        protected override List<IPackStep> PackSteps { get; } = new List<IPackStep>() {
            new PackStep("Поставить банку на конвейер"),
            new PackStep("Засыпать материал в банку"),
            new PackStep("Запечатать защитной фольгой"),
            new PackStep("Закрыть банку крышкой"),
        };
    }
}
