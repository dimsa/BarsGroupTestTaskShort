using System;

namespace ProductPackagerApp.Common
{   
    /*
     * Этот класс сделан, чтобы при инициализации IoC-контейнера не было непонятных имен типа "c", "1"  и т.д. 
     * Также содержит константы, чтобы проверять правильность имён уже на уровне компиляции
     */
    public class ElementNames
    {       
        public const string ScreenLogger = "ScreenLogger";
        public const string FileLogger = "FileLogger";

        public const string Liquid = "Liquid";
        public const string Dry = "Dry";
        public const string Soft = "Soft";

        public static string GetLoggerName(char command)
        {
            switch (command)
            {
                case 'c':
                    return ScreenLogger;
                case 'f':
                    return FileLogger;

                default:
                    throw new Exception("Неизвестный тип логгера");
            }
        }

        public static string GetProductTypeName(char command)
        {
            switch (command)
            {
                case '1':
                    return Liquid;
                case '2':
                    return Dry;
                case '3':
                    return Soft;

                default:
                    throw new Exception("Неизвестный тип продукта");
            }
        }
    }
}
