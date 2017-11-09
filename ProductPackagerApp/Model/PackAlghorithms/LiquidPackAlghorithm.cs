using System.Collections.Generic;
using ProductPackagerApp.Model.PackSteps;

namespace ProductPackagerApp.Model.PackAlghorithms
{
    public class LiquidPackAlghorithm : PackAlghorithm
    {
        protected override List<IPackStep> PackSteps { get; } = new List<IPackStep>()   {
            new PackStep("Поставить бутылку на конвейер"),
            new PackStep("Залить жидкость в бутылку"),
            new PackStep("Закрутить бутылку крышкой "),
        };
    }
}
