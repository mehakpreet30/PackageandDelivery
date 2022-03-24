using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery.Repositorys
{
    public interface IPackageandDelivery
    {
        public double PackagingAndDelivery(ProcessRequest req);
    }
}
