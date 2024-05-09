using System.Net;

namespace sicotyc.entities.Models
{
    public class ResultProcess
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
