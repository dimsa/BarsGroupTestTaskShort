using ProductPackagerApp.Ioc;

namespace ProductPackagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocContainerInitilizer.InitContainer();
            var app = container.Resolve<ConsoleInterface>();

            app.Process();
        }

       
    }
}
