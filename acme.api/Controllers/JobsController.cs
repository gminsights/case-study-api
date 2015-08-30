using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using acme.api.Models;

namespace acme.api.Controllers
{
    public class JobsController : ApiController
    {
        Job[] availableJobs = new Job[]
        {
                new Job { jobId = 1, jobTitle = "Developer", location = "Sydney", contactPerson = "Bruce Sweeney" },
                new Job { jobId = 2, jobTitle = "Manager", location = "Brisbane", contactPerson = "Eoin McDonald" },
                new Job { jobId = 3, jobTitle = "Executive", location = "Melbourne", contactPerson = "Kerra Woolley" }
        };
        // GET: api/Jobs
        public IEnumerable<Job> Get()
        {
            return availableJobs;
        }

        
        public string Get(int id)
        {
            // TODO


            return null;
        }

     
        public void Post([FromBody]string value)
        {
            //TODO
        }

        
        public void Put(int id, [FromBody]string value)
        {
            // TODO
        }

        
        public void Delete(int id)
        {
            //TODO
        }
    }
}
