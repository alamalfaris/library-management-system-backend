using LibraryManagementSystemBackend.Constants;
using LibraryManagementSystemBackend.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace LibraryManagementSystemBackend.Helpers
{
    public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            logger.LogError(exception, "Exception occurred: {Ex}", exception.ToString());

            var response = ApiResponse<string>.FailureResponse(StatusCodes.Status500InternalServerError, GlobalConstants.Status500InternalServerError, 
                GlobalConstants.MessageSomethingWrong, null);

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

            return true;
        }
    }
}
