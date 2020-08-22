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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SetPreferredCustomerData(PreferredCustomer objPrefCustomer)
        {
            int customer_number;
            decimal purchase_amount;
            decimal five_percent = 0.05m;
            decimal six_percent = 0.06m;
            decimal seven_percent = 0.07m;
            decimal ten_percent = 0.1m;

            if (int.TryParse(textBox1.Text, out customer_number))
            {
                objPrefCustomer.customerNumber = customer_number;
            } else
            {
                MessageBox.Show("Invalid customer number");
            }

            if (decimal.TryParse(textBox2.Text, out purchase_amount))
            {
                objPrefCustomer.purchaseAmount = purchase_amount;
            } else
            {
                MessageBox.Show("Invalid customer number");
            }

            if (objPrefCustomer.purchaseAmount >= 500 && objPrefCustomer.purchaseAmount < 1000)
            {
                objPrefCustomer.customerDiscount = (objPrefCustomer.purchaseAmount * five_percent);
            } else if (objPrefCustomer.purchaseAmount >= 1000 && objPrefCustomer.purchaseAmount < 1500)
            {
                objPrefCustomer.customerDiscount = (objPrefCustomer.purchaseAmount * six_percent);
            } else if (objPrefCustomer.purchaseAmount >= 1500 && objPrefCustomer.purchaseAmount < 2000)
            {
                objPrefCustomer.customerDiscount = (objPrefCustomer.purchaseAmount * seven_percent); 
            } else if (objPrefCustomer.purchaseAmount >= 2000)
            {
                objPrefCustomer.customerDiscount = (objPrefCustomer.purchaseAmount * ten_percent);
            }
        }

        private void btn_getDiscount_Click(object sender, EventArgs e)
        {
            PreferredCustomer objPrefCustomer = new PreferredCustomer();

            SetPreferredCustomerData(objPrefCustomer);

            lbl_cNum.Text = objPrefCustomer.customerNumber.ToString();
            lbl_pAmount.Text = objPrefCustomer.purchaseAmount.ToString("c");
            lbl_cDiscount.Text = objPrefCustomer.customerDiscount.ToString("c");
            
        }
    }
}
