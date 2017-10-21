using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailToBuyer
{
    public class Gmail
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Gmail(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Send(MailMessage msg)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(Username, Password);
            bool IsCont = true;
            while (IsCont)
            {
                try
                {
                    client.Send(msg);
                }
                catch (Exception ex)
                {

                }
                IsCont = false;
            }
            
            
        }
    }
}
