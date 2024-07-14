namespace Journey.Exception.ExceptionBase;

public abstract class JourneyException : SystemException
{
    protected JourneyException(string message) : base(message) {}
    
    public abstract int StatusCode { get; }
    public abstract List<string> GetErrors();
}