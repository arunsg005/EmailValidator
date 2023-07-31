
namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using StatusRetrievalApplication.Validation;
    using System.Threading.Tasks;
    using WebApplication1.Models;
    using WebApplication1.Services;

    [ApiController]
    [Route("api")]
    public class FetchStatusesController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ILogger<FetchStatusesController> _logger;

        public FetchStatusesController(IEventService eventService, ILogger<FetchStatusesController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        [Route("statusCheck/Email")]
        [HttpGet]
        public async Task<IActionResult>  GetStatuses(string email)
        {
            _logger.LogInformation("StatusCheck API invoked..");

            if (email == null)
            {
                return BadRequest("{message : please provide valid email ex: abc@example.com}");
            }
            else
            {
                var result = BusinessValidation.ValidateEmailPattern(email);
                if (!result)
                {
                    return BadRequest("{message : please provide valid email ex: abc@example.com}");
                }
            }

            var statusDetail = await _eventService.GetStatusDetails(email);
            if(statusDetail.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return StatusCode((int)System.Net.HttpStatusCode.OK,statusDetail);
            }

            else if(statusDetail.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest,"{message : Bad Request}");
            }

            else if (statusDetail.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                return StatusCode((int)System.Net.HttpStatusCode.TooManyRequests,"{message : Too Many Attempts}");
            }
            
            else if (statusDetail.StatusCode == System.Net.HttpStatusCode.GatewayTimeout)
            {
                return StatusCode((int)System.Net.HttpStatusCode.GatewayTimeout, "{message : Gateway Timeout”}");
            }
            else 
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError,"{message : Internal Server Error}");
            }
        }
    }
}
