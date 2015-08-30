using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.api.Models
{
    public class Applicant
    {
        public string name { get; set; }
        public string emailId { get; set; }
        public string phoneNumber { get; set; }
        public string jobTitle { get; set; }
        public string comments { get; set; }
    }
}
