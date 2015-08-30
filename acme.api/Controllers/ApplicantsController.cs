using acme.api.Helpers;
using acme.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace acme.api.Controllers
{
    public class ApplicantsController : ApiController
    {
        // GET: api/Applicants
        public IEnumerable<string> Get()
        {
            //TODO
            return null;
        }

        // GET: api/Applicants/5
        public string Get(int id)
        {
            //TODO
            return null;
        }

        // POST: api/Applicants
        public object Post([FromBody]Applicant applicant)
        {
            //TODO -- We can now store the applicant information into any database.
            
            // mailing 
            try
            {
              var x =  Helper.sendMail(applicant);
                
              return null;
            }
            catch (Exception exp)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exp);
            }
        }

        // PUT: api/Applicants/5
        public void Put(int id, [FromBody]string value)
        {
            //TODO 
        }

        // DELETE: api/Applicants/5
        public void Delete(int id)
        {
            //TODO
        }
    }
}
