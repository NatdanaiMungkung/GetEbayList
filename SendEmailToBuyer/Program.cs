using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailToBuyer
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileReader = new StreamReader("report.txt");
            string line;
            fileReader.ReadLine();
            var emailList = new List<Report>();
            while ((line = fileReader.ReadLine()) != null)
            {
                var eachReport = new Report();
                eachReport.Email = line.Split('\t')[4];
                eachReport.Name = line.Split('\t')[16];
                //eachReport.EarliestDeliveryDate = Convert.ToDateTime(line.Split('\t')[31]);
                //eachReport.LatestDeliveryDate = Convert.ToDateTime(line.Split('\t')[32]);
                eachReport.productName = line.Split('\t')[8];
                emailList.Add(eachReport);
            }
            Gmail gmail = new Gmail("michaelfhughes2016@gmail.com", "xxnjlvkpcjltfnwm");

            foreach (var each in emailList)
            {
                MailMessage msg = new MailMessage("michaelfhughes2016@gmail.com", each.Email);
                msg.Subject = "Information regarding " + each.productName;
                msg.Body = "Dear " + each.Name + ",\n" +

                    "Nice to do business with you We hope you enjoy your trading experience with us.\n" +

"Please notice: We have been shipped your order next working day after your payment is clear.Due to the international transportation, we cannot control the shipping scheduling, and also different country customs has different customs inspection time and some reasons caused by your Local postman service, etc , Normally, the shipment takes around 10 - 25 working days to your country via China Airmail registered Post .(Sometime, it's faster than expected) If the item not arrives within 25 working days, please don't hesitate to contact us for solution before you leave us any non - positive feedback or open case We are sincerely here to make you 100 % satisfied.\n" +

 "If you are happy with this purchase and service, please be sure to positive feedback in Real 5★★★★★stars we really will appreciate this and look forward to the next time we may be of service to you.\n" +

 "Kindest Regards,\n" +
 "Customer Service Department\n";
                Console.WriteLine("Email sending to " + each.Email + " (" + each.Name + ") for " + "'" + each.productName + "'");
                gmail.Send(msg);
                Console.WriteLine("Email sent to " + each.Email + " (" + each.Name + ") for " + "'" + each.productName + "'");
            }
            Console.ReadLine();

            //"This is a courtesy message to notice you that the package will arrive between 2016 - 11 - 03 and 2016 - 11 - 17 as we estimate.\n\n" +

            //        "Feel free to REPLY THIS MESSAGE if you got issues as below, we will response you in 24 hours(Monday to Friday) to make it right for you!\n\n" +

            //        "1.Didn't get the package after 2016-11-17.\n" + 
            //        "2.The package got damaged during the shipping and can't be used.\n" +
            //        "3.Something wrong with the product you get.\n\n" + 

            //        "To make sure your problem of the issues 2 and 3 can be fixed ASAP, taking photos of the damaged package or missing ones or wrong product will be highly appreciated, that can help us locate the issues and find the best way to fix the problem for you.\n\n" +

            //        "If you have got the package from us already, and enjoy the product, it will be highly appreciated if you can leave us five -star, positive feedback, which will encourage us to provide better product and service in the future, and we are glad to do the same for you.\n\n" +

            //       "Have a nice day!\n\n" +


            //       "Best wishes, ";

            

        }
    }
}



