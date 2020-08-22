using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer_object = new Customer();
            SetCustomerData(customer_object);
            lbl_pName.Text = customer_object.Name;
            lbl_pAddress.Text = customer_object.Address;
            lbl_pPhoneNum.Text = customer_object.PhoneNumber;
            lbl_cNum.Text = customer_object.customerNumber.ToString();
            lbl_mail.Text = customer_object.Mailing.ToString();
        }

        private void SetCustomerData(Customer customer_object)
        {
            bool mailing;

            if (txt_pName.Text != "")
            {
                customer_object.Name = txt_pName.Text;
            } else
            {
                MessageBox.Show("Enter a name");
            }
            if (txt_pAddress.Text != "")
            {
                customer_object.Address = txt_pAddress.Text;
            } else
            {
                MessageBox.Show("Enter an address");
            }
            if (txt_pPhoneNum.Text != "")
            {
                customer_object.PhoneNumber = txt_pPhoneNum.Text;
            } else
            {
                MessageBox.Show("Enter a number");
            }
            if (bool.TryParse(chk_mail.Checked.ToString(), out mailing)){
                customer_object.Mailing = mailing;
            } else
            {
                MessageBox.Show("Invalid mailing");
            }
        }

    }
}
