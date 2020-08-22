using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomerClasses
{
    class PreferredCustomer: Customer
    {
        decimal purchase_amount;
        decimal customer_discount;

        public decimal purchaseAmount
        {
            get
            {
                return purchase_amount;
            }
            set
            {
                purchase_amount = value;
            }
        }

            public decimal customerDiscount
        {
            get
            {
                return customer_discount;
            }
            set
            {
                customer_discount = value;
            }      
        }
    }
}
