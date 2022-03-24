using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery.Repositorys
{
    public class PackageandDeliveryRepo : IPackageandDelivery
    {
        
        public double PackagingAndDelivery(ProcessRequest req)
        {
            ProcessResponse resultResponse = new ProcessResponse();

            DatabaseModelClass obj = new DatabaseModelClass();

            var a = obj.package.Single(a => a.Componenttypes == req.ComponentType);
                
            double n = req.Quantity;

            if (req.ComponentType == a.Componenttypes)
            {
                resultResponse.PackagingAndDeliveryCharge = a.packagedeliverycharge * n;
            }
            else
            {
                resultResponse.PackagingAndDeliveryCharge = a.packagedeliverycharge * n;
            }
            return resultResponse.PackagingAndDeliveryCharge;
        }
    }
}
