using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //variable
            int NumberOfPackages;
            double PricePerPackage;

            if (int.TryParse(txtpackages.Text, out NumberOfPackages) && double.TryParse(txtperpackage.Text, out PricePerPackage))
            {
                NumberOfPackages = int.Parse(txtpackages.Text);
                PricePerPackage = double.Parse(txtperpackage.Text);

                //subtotal Before Discount
                double SubTotal;

                SubTotal = NumberOfPackages * PricePerPackage;

                //Discount Rate
                double discountRate = 0;

                //Discount Amount
                double discountAmount = 0;

                // calculating discount
                if (NumberOfPackages >= 10 && NumberOfPackages <= 19)
                {
                    discountAmount = SubTotal * 0.2;
                    discountRate = 20;
                }
                else if (NumberOfPackages >= 20 && NumberOfPackages <= 49)
                {
                    discountAmount = SubTotal * 0.3;
                    discountRate = 30;
                }
                else if (NumberOfPackages >= 50 && NumberOfPackages <= 99)
                {
                    discountAmount = SubTotal * 0.4;
                    discountRate = 40;
                }
                else if (NumberOfPackages >= 100)
                {
                    discountAmount = SubTotal * 0.5;
                    discountRate = 50;
                }


                //total
                double Total;
                Total = SubTotal - discountAmount;

                //list box
                listBox1.Items.Add("Number Of Packages : " + txtpackages.Text);
                listBox1.Items.Add("Price Per Package : $ " + txtperpackage.Text);
                listBox1.Items.Add("Subtotal(Before Discount) : $ " + SubTotal);
                listBox1.Items.Add("Discount Rate : " + discountRate);
                listBox1.Items.Add("Discount Amount : " + discountAmount);
                listBox1.Items.Add("Total Amount (After Discount) : " + Total);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpackages.Clear();
            txtperpackage.Clear();

            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
        
    

