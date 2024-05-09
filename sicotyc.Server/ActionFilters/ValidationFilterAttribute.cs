using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using sicotyc.contracts;

namespace sicotyc.Server.ActionFilters
{
    public class ValidationFilterAttribute : IActionFilter
    {
        private readonly ILoggerManager _logger;

        public ValidationFilterAttribute(ILoggerManager logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            try {
                var action = context.RouteData.Values["action"];
                var controller = context.RouteData.Values["controller"];

                var param = context.ActionArguments
                    .SingleOrDefault(x => x.Value != null && x.Value.ToString().Contains("Dto")).Value;
                //.SingleOrDefault(x => x.Value != null ? x.Value.ToString().Contains("Dto") : false).Value;

                if (param == null)
                {
                    _logger.LogError($"Objeto enviado desde el cliente es nulo. Controller: {controller}, action: {action}");
                    return;
                }

                if (!context.ModelState.IsValid)
                {
                    _logger.LogError($"Invalid model state for the object. Controller: {controller}, action: {action}");
                    context.Result = new UnprocessableEntityObjectResult(context.ModelState);
                }
            } 
            catch (Exception ex) {
                _logger.LogError($"Error en el filtro de validación. Detalle: {ex.Message}");
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }            
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

    }
}
