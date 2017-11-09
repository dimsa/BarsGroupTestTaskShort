using System;
using Castle.Windsor;
using ProductPackagerApp.model;
using Castle.MicroKernel.Registration;
using ProductPackagerApp.Common;

/*
 * Класс программы, отвечает за ввод/вывод информации.
 * Вся работа с консолью скрыта в этом классе. Наружу только делегат торчит
 */
public class ConsoleInterface
{    
    private IWindsorContainer _container;
    public ConsoleInterface(IWindsorContainer container)
    {
        _container = container;
        _container.Register(Component.For<InformDelegate>().Instance(Inform));
    }

    private void Inform(string message, ConsoleColor color = ConsoleColor.Gray)
    {
        if (Console.CursorLeft > 0)
            Console.WriteLine();

        var col = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = col;
    }

    private void Pack()
    {
        var product = GetProduct();
        var logger = GetLogger();

        var packager = _container.Resolve<Packager>();
        packager.Pack(product, logger);
    }

    private char GetProduct()
    {
        Inform("Выберите тип продукта, например 1-3");
        var key = Console.ReadKey();
        return key.KeyChar;
    }
    private char GetLogger()
    {
        Inform("Выберите тип логгера, например c или f");
        var key = Console.ReadKey();
        return key.KeyChar;
    }

    public void Process()
    {
        SayHello();
        do
        {
            var key = GetCommand();

            switch (key)
            {
                case
                    's':
                    Pack();
                    break;
                case
                    'q':
                    SayBye();
                    return;
                default:
                    SayCommandUnknown();
                    break;
            }
        } while (true);
    }

    private char GetCommand()
    {
        Inform("Введите s для упаковки или q для выхода и программы");
        var input = Console.ReadKey();
        return input.KeyChar;
    }

    private void SayBye()
    {
        Inform("До свидания!");
    }

    private void SayCommandUnknown()
    {
        Inform("Неизвестная команда");
    }

    private void SayHello()
    {
        Inform("Добро пожаловать в приложение для упаковки");
    }
}
