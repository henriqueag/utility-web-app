using Domain.Exceptions;
using Domain.ValueObjects;

namespace Presentation.RestApi.Filters;

public class UserFriendlyExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is UserFriendlyException ex
            && context.Exception.GetType() == typeof(UserFriendlyException)
            && !context.ExceptionHandled)
        {
            var response = ex.Errors is null 
                ? new ErrorMessage
                {
                    Code = ex.Code,
                    Message = ex.Message
                }
                : new ErrorMessageWithDetails
                {
                    Code = ex.Code,
                    Message = ex.Message,
                    DetailedErrors = ex.Errors
                };

            context.Result = new ObjectResult(response);
            context.HttpContext.Response.StatusCode = 400;

            context.ExceptionHandled = true;
        }
    }
}
