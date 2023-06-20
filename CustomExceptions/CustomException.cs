using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Practical_10.CustomExceptions
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is DivideByZeroException)
            {
                context.Result = new ContentResult
                {
                    Content = "Error: Divide by zero is not allowed.",
                    StatusCode = 500
                };
                context.ExceptionHandled = true;
            }
        }
    }    
}
