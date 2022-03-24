using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery.Services
{
    public interface IPackageandDeliveryserv
    {
        public double PackagingAndDelivery(ProcessRequest req);
    }
}
