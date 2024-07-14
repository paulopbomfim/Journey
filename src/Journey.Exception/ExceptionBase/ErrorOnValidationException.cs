using System.Net;

namespace Journey.Exception.ExceptionBase;

public class ErrorOnValidationException : JourneyException
{
    private readonly List<string> _errors;
    
    public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
    {
        _errors = errorMessages;
    }

    public override int StatusCode => (int)HttpStatusCode.BadRequest;
    public override List<string> GetErrors()
    {
        return _errors;
    }
}