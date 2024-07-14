using Journey.Communication.Responses;
using Journey.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Journey.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is JourneyException)
        {
            HandleProjectException(context);
        }
        else
        {
            ThrowUnknownError(context);
        }
    }

    private static void HandleProjectException(ExceptionContext context)
    {
        var journeyException = (JourneyException)context.Exception;
        context.HttpContext.Response.StatusCode = journeyException.StatusCode;

        var errorResponse = new ErrorResponse(journeyException.GetErrors());
        context.Result = new ObjectResult(errorResponse);
    }

    private static void ThrowUnknownError(ExceptionContext context)
    {
        var errorResponse = new ErrorResponse("Erro desconhecido");

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}