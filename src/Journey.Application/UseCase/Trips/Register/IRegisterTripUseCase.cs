using Journey.Communication.Requests;

namespace Journey.Application.UseCase.Books.Register;

public interface IRegisterTripUseCase
{
    Task Execute(RegisterTripRequest request);
}