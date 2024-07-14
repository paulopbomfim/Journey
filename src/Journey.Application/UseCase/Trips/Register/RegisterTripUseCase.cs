using Journey.Communication.Requests;
using Journey.Exception.ExceptionBase;

namespace Journey.Application.UseCase.Books.Register;

public class RegisterTripUseCase : IRegisterTripUseCase
{
    public async Task Execute(RegisterTripRequest request)
    {
        Validate(request);
        
        return;
    }

    private static void Validate(RegisterTripRequest request)
    {
        var validator = new RegisterTripValidation();

        var result = validator.Validate(request);

        if (result.IsValid) return;
        
        var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
        throw new ErrorOnValidationException(errorMessages);
    }
}