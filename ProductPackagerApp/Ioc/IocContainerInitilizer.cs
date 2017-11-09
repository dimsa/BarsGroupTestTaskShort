using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ProductPackagerApp.Common;
using ProductPackagerApp.Loggers;
using ProductPackagerApp.model;
using ProductPackagerApp.Model.PackAlghorithms;
using ProductPackagerApp.Model.Products;

namespace ProductPackagerApp.Ioc
{  
   internal class IocContainerInitilizer
    {
        public static IWindsorContainer InitContainer()
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IWindsorContainer>().Instance(container));
            container.Register(Component.For<Packager>());
            container.Register(Component.For<ConsoleInterface>());

            RegisterPackAlgorithms(container);
            RegisterProducts(container);
            RegisterLoggers(container);

            return container;
        }

        private static void RegisterPackAlgorithms(WindsorContainer container)
        {
            // Регистрируем всех реализаторов IPackAlgorithm
            container.Register(
                Classes.FromAssemblyContaining<IPackAlghorithm>()
                    .BasedOn<IPackAlghorithm>());
        }

        private static void RegisterProducts(WindsorContainer container)
        {
            container.Register(
                Component.For<IProduct>()
                    .ImplementedBy<LiquidProduct>()
                    .LifestyleTransient()
                    .Named(ElementNames.Liquid)
                    .DependsOn(Dependency.OnComponent<IPackAlghorithm, LiquidPackAlghorithm>())
                );

            container.Register(
                Component.For<IProduct>()
                    .ImplementedBy<DryProduct>()
                    .LifestyleTransient()
                    .Named(ElementNames.Dry)
                    .DependsOn(Dependency.OnComponent<IPackAlghorithm, DryPackAlghorithm>())
            );

            container.Register(
                Component.For<IProduct>()
                    .ImplementedBy<SoftProduct>()
                    .LifestyleTransient()
                    .Named(ElementNames.Soft)
                    .DependsOn(Dependency.OnComponent<IPackAlghorithm, SoftPackAlghorithm>())
            );
        }

        private static void RegisterLoggers(WindsorContainer container)
        {
            container.Register(
                Component.For<ILogger>()
                    .ImplementedBy<ScreenLogger>()
                    .Named(ElementNames.ScreenLogger));

            container.Register(
                Component.For<ILogger>()
                    .ImplementedBy<FileLogger>()
                    .Named(ElementNames.FileLogger));
        }
    }
}
