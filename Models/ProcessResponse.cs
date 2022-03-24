using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery.Models
{
    public class ProcessResponse
    {
        public int RequestId { get; set; }
        public double ProcessingCharge { get; set; }

        public double PackagingAndDeliveryCharge { get; set; }

        public DateTime DateOfDelivery { get; set; }

        public string CreditLimits { get; set; }


    }
}
