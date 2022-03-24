using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Repositorys;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery.Services
{
    public class PackageandDeliveryServ : IPackageandDeliveryserv
    {
        private readonly IPackageandDelivery _packagedeliRepo;

        public PackageandDeliveryServ(IPackageandDelivery packagedeliRepo)
        {
            _packagedeliRepo = packagedeliRepo;
        }
        public double PackagingAndDelivery(ProcessRequest req)
        {
            return _packagedeliRepo.PackagingAndDelivery(req);
        }
    }
}
