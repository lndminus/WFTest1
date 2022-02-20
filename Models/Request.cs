using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFinder.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string RequestText { get; set; }
        public bool RequestStatus { get; set; }
        public int ClientId { get; set; }
        public int AdPostId { get; set; }
    }
}
