using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCapa.Models.HelperClasses
{
    public class SendEmailClass
    {

        public string Profile_name { get; set; } = "QMS";
        public string Recipients { get; set; } = "ismael.figueroa@panasonicautomotive.com";
        public string Copy_recipients { get; set; } = "ismael.figueroa@panasonicautomotive.com";
        public string Body { get; set; } = "Test";
        public string Body_format { get; set; } = "HTML";
        public string Subject { get; set; } = "Test";       

        public SendEmailClass()
        {

        }
        public SendEmailClass(string recipients, string copy_recipients, string body, string subject)
        {           
            Recipients = recipients;
            Copy_recipients = copy_recipients;
            Body = body;         
            Subject = subject;          
        }
        public async Task SendEmailGeneric()
        {
            using(var db = new QAD_QMSContext())
            {
                try
                {
                    var email = await db.Database.ExecuteSqlRawAsync("EXEC dbo.[spSendEmail] @profile_name = {0}, @recipients = {1}, @copy_recipients = {2}, @body = {3}, @body_format = {4}, @subject = {5}", Profile_name, Recipients, Copy_recipients, Body, Body_format, Subject);
                }
                catch (Exception ex)
                {
                    ex.InnerException.ToString();
                    throw ex;
                }
                
            }
        }


    }
}
