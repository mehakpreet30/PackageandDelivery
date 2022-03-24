using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery.Models;

namespace PackagingAndDelivery
{
    public class DatabaseModelClass
    {
        public List<DatabseModel> package = new List<DatabseModel>()
        {
            new DatabseModel() { Componenttypes="Integral" , packagedeliverycharge=300},
            new DatabseModel() { Componenttypes="Accessory" , packagedeliverycharge=150},
            new DatabseModel() { Componenttypes="Protective Sheath" , packagedeliverycharge=50}


        };

    }
}
