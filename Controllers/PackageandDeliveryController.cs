using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Services;
using PackagingAndDelivery.Repositorys;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageandDeliveryController : ControllerBase
    {
        private IPackageandDeliveryserv _packagesServ;

        public PackageandDeliveryController(IPackageandDeliveryserv packagesServ)
        {
            _packagesServ = packagesServ;
        }

        [HttpPost]
        public double GetPackageandDeliveryCharge(ProcessRequest req)
        { 
            return _packagesServ.PackagingAndDelivery(req);
        }
    }
}
