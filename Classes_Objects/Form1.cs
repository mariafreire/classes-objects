using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhoneInfo_Click(object sender, EventArgs e)
        {
            CellPhone phonel = new CellPhone();
            phonel.RetailPrice = 259.00;
            phonel.PhoneColor = Color.Green;
            phonel.ScreenSize = 6.1f;
            phonel.Model = "Samsung Mega";
            textBox1.Text = "This is a " + phonel.Model +
                " phone. Its screen size is " + phonel.ScreenSize.ToString("N1") +
                " inch in " + phonel.PhoneColor.ToString() +
                " color. Its price tag is " + phonel.RetailPrice.ToString("c2");
        }
        CellPhone phone2 = new CellPhone();

        private void btnPhoneInfoCallMethod_Click(object sender, EventArgs e)
        {
            phone2.RetailPrice = 399.00;
            phone2.PhoneColor = Color.Black;
            phone2.ScreenSize = 5.5f;
            phone2.Model = "Samsung S5";
            textBox1.Text = phone2.PhoneInfo();
        }

        private void btnGetDiscount_Click(object sender, EventArgs e)
        {
            textBox1.Text = phone2.Model + " 's original price is " +
                phone2.RetailPrice.ToString("c2") + ". ";
            double finalprice = phone2.RetailPrice - phone2.discount(0.3);
            textBox1.AppendText(Environment.NewLine + "With a 30% discount, you pay " +
                finalprice.ToString("c2") + ".");
        }

        private void btnUsingOtherConstructors_Click(object sender, EventArgs e)
        {
            CellPhone phone3 = new CellPhone("Nokia Lumia 800");
            textBox1.Text = phone3.PhoneInfo();
            CellPhone phone4 = new CellPhone("iPhone 6s", Color.Gold, 4.7f, 700);
            textBox1.AppendText(Environment.NewLine + phone4.PhoneInfo());
        }
    }
}
