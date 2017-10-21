using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailToBuyer
{
    public class Report
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime EarliestDeliveryDate { get; set; }
        public DateTime LatestDeliveryDate { get; set; }
        public string productName { get; set; }
    }
}
