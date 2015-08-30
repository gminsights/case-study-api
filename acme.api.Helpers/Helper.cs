using acme.api.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace acme.api.Helpers
{
    public static class Helper
    {
        public static bool sendMail(Applicant applicant)
        {
            // emailing details to careers@acme.com.au
            var isSuccessful= sendMail(applicant, "gminsights@outlook.com", false);
            
            // sending acknowledgement to applicant
            isSuccessful = sendMail(applicant, applicant.emailId, true);

            return isSuccessful;
        }
        private static bool sendMail(Applicant applicant, string toAddress, bool toApplicant)
        {
            var fromAddress = ConfigurationManager.AppSettings["fromAddress"];
            
            using (MailMessage mm = new MailMessage(fromAddress, toAddress))
            {
                // changing subject and body based on to applicant flag
                if (toApplicant)
                {
                    mm.Subject = "Your application received";
                    mm.Body = "Thank you for your application, we will now review and get back to you. Regards , Acme Careers";
                }
                else
                {
                    mm.Subject = "Application for " + applicant.jobTitle;
                    var bodymessage = "Applicant Details:";
                    bodymessage += "\n Name: " + applicant.name;
                    bodymessage += "\n emailID: " + applicant.emailId;
                    bodymessage += "\n phoneNumber: " + applicant.phoneNumber;
                    bodymessage += "\n jobTitle: " + applicant.jobTitle;
                    bodymessage += "\n Comments: " + applicant.comments;
                    mm.Body = bodymessage;


                }         
                        
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["smtpHost"];
                smtp.EnableSsl = ConfigurationManager.AppSettings["enableSSL"] == "Yes" ? true :false;
                NetworkCredential NetworkCred = new NetworkCredential(ConfigurationManager.AppSettings["smtpUsername"], ConfigurationManager.AppSettings["smtpPassword"]);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = ConfigurationManager.AppSettings["defaultCreds"] == "Yes" ? true : false;
                smtp.Credentials = NetworkCred;
                smtp.Port = int.Parse(ConfigurationManager.AppSettings["smtpPort"]);
                try
                {
                    // TODO Logging needs implemented here
                    smtp.Send(mm);
                    return true;
                }
                catch(Exception exp) {
                    // TODO Logging needs implemented here
                    return false;
                }
               
            }
        }
    }
}
