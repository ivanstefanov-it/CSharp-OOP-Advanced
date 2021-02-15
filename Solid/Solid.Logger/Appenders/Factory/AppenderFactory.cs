namespace Solid.Logger.Appenders.Factory
{
    using Contracts;
    using Layouts.Contracts;
    using Solid.Logger.Appenders.Contracts;
    using Solid.Logger.Loggers;

    using System;

    public class AppenderFactory : IAppenderFactory
    {
       
        IAppender IAppenderFactory.CreateApender(string type, ILayout layout)
        {
            type = type.ToLower();

            switch (type)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
