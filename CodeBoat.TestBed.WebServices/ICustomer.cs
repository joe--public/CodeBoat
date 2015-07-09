using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBoat.TestBed.WebServices
{
    interface ICustomer
    {
        string GetCustomerName(int customerId);
    }
}
