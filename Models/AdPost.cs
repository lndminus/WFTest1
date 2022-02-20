using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFinder.Models
{
    public class AdPost
    {
        public int AdPostId { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public string Salary { get; set; }
        public string ContactPhone { get; set; }
        public int ClientId { get; set; }
    }
}
