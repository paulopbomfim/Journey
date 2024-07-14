using FluentValidation;
using Journey.Communication.Requests;

namespace Journey.Application.UseCase.Books;

public class RegisterTripValidation : AbstractValidator<RegisterTripRequest>
{
    public RegisterTripValidation()
    {
        RuleFor(expense => expense.Name)
            .NotEmpty().WithMessage("O Campo nome não pode estar vazio.");

        RuleFor(expense => expense.StartDate)
            .LessThan(DateTime.UtcNow).WithMessage("A viagem não pode ser registrada para uma data passada.");

        RuleFor(expense => expense.EndDate)
            .GreaterThanOrEqualTo(expense=> expense.StartDate).WithMessage("A viagem deve terminar apos a data de início.");
    }
}