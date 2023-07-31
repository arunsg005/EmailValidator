using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EventService : IEventService
    {
        private readonly ILogger<EventService> _logger;
        public EventService(ILogger<EventService> logger)
        {
            _logger = logger;
        }

        public async Task<StatusDetail> GetStatusDetails(string email)
        {
            StatusDetail statusDetail = new StatusDetail();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://1uf1fhi7yk.execute-api.eu-west-2.amazonaws.com/default/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = await client.GetAsync($"events?email={email}");
                    if (response.IsSuccessStatusCode)
                    {
                        statusDetail = JsonConvert.DeserializeObject<StatusDetail>(await response.Content.ReadAsStringAsync());
                        statusDetail.Events = statusDetail.Events.Where(x => x.Status == "Busy" || x.Status == "OutOfOffice").ToList();
                        statusDetail.StatusCode = response.StatusCode;
                    }
                    else
                    {
                        _logger.LogInformation($"API returned with unsucess status code:{response.StatusCode} and Message:{response.Content}");
                        statusDetail.StatusCode = response.StatusCode;
                    }
                }
                catch(Exception ex)
                {
                    _logger.LogError($"Exception occured while invoking status API:{ex.Message}");
                }

            }
            return statusDetail;

        }
    }
}
