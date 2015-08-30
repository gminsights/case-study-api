using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.api.Models
{
    public class Job
    {
        
        public int jobId { get; set; }
        public string jobTitle { get; set; }
        public string location { get; set; }
        public string contactPerson { get; set; }
    }

  
}
