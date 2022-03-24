using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery
{
    public class RequestDataHelper
    {
        public static ProcessRequest requestObject = new ProcessRequest()
        {

            ComponentName = "Dress",
            Name = "Aby",
            ComponentType = "Integral",
            ContactNumber = "564578963",
            CreditCardNumber = "454244555456644",
            CreditLimit = "1000",
            IsPriorityRequest = false,
            Quantity = 2
        };
    }
}
