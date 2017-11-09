using ProductPackagerApp.Model.PackSteps;

namespace ProductPackagerApp.Model
{
    // Возможны какие-то конкретные реализации PackStep, но в рамках тестового здания они опущены
    public class PackStep : IPackStep
    {
        public string GetStepMessage()
        {
            return _message;
        }

        public void Make()
        {            
            // Данный метод выполняет операцию. 
        }

        public PackStep(string message)
        {
            _message = message;
        }       

        private readonly string _message;
    }
}
