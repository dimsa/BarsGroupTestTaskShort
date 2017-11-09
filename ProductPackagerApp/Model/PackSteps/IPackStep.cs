namespace ProductPackagerApp.Model.PackSteps
{
    public interface IPackStep
    {        
        string GetStepMessage();
        void Make();
    }
}
