using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomerClasses
{
    class Person
    {
        string name;
        string address;
        string phone_number;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }
    }

    class Customer : Person
    {
        int customer_number;
        bool mailing;

        public int customerNumber
        {
            get
            {
                return customer_number;
            }
            set
            {
                customer_number = value;
            }
        }
        public bool Mailing
        {
            get
            {
                return mailing;
            }
            set
            {
                mailing = value;
            }
        }
    }
}
