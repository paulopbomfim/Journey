using Journey.Application.UseCase.Books.Register;
using Journey.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterTripUseCase useCase,
        [FromBody] RegisterTripRequest request)
    {
        await useCase.Execute(request);

        return Created();
    }
}

