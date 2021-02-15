namespace Solid.Logger.Appenders.Factory.Contracts
{
    using Solid.Logger.Appenders.Contracts;
    using Solid.Logger.Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender CreateApender(string type, ILayout layout);
    }
}
