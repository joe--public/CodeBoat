using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBoat.TestBed.WebServices
{
    public class Customer: ICustomer
    {
        public string GetCustomerName(int customerId)
        {
            return string.Format("{0}, New Customer Name", customerId);
        }
    }
}
