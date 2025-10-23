using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using JomarHealthCare.API.ErrorHandlers;

namespace JomarHealthCare.API
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            GlobalProblemDetails problemDetails;

            switch (exception)
            {
                case ValidationException validationException:
                    problemDetails = ValidationError(validationException, httpContext.TraceIdentifier);
                    httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                    break;

                default:
                    problemDetails = new GlobalProblemDetails
                    {
                        TraceIdentifier = httpContext.TraceIdentifier,
                        Detail = "Internal server error",
                        Title = "Server error",
                        Status = StatusCodes.Status500InternalServerError,
                        Path = httpContext.Request.Path,
                        Errors = new Dictionary<string, List<string>>
                        {
                            { "REQUEST_ERROR", new List<string> { exception.Message.ToString() } }
                        }
                    };
                    httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    break;
            }

            problemDetails.Path ??= httpContext.Request.Path;

            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
            return true;
        }

        private GlobalProblemDetails ValidationError(ValidationException exception, string traceIdentifier)
        {
            var problemDetails = new GlobalProblemDetails
            {
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = "Validation error",
                TraceIdentifier = traceIdentifier,
                Errors = new Dictionary<string, List<string>>()
            };

            foreach (var error in exception.Errors)
            {
                if (problemDetails.Errors.ContainsKey(error.PropertyName))
                {
                    problemDetails.Errors[error.PropertyName].Add(error.ErrorMessage);
                }
                else
                {
                    problemDetails.Errors[error.PropertyName] = new List<string> { error.ErrorMessage };
                }
            }
            if (!problemDetails.Errors.Any())
            {
                if (!exception.Errors.Any())
                {
                    problemDetails.Errors.Add("REQUEST_ERROR", new List<string> { exception.Message });
                }
            }

            return problemDetails;
        }
    }
}
