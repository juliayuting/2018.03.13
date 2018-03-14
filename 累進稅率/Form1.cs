using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 累進稅率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal taxpay = 0m;      
            decimal icome = Decimal.Parse(textBox1.Text);
            if (icome<=540000)
            {
                taxpay = icome * 0.05m;
                textBox2.Text = taxpay.ToString();
            }
            else if (540000<icome && icome<=1210000)
            {
                taxpay =540000*0.05m + (icome - 540000) * 0.12m;
                textBox2.Text = taxpay.ToString();
            }
            if (1210000<icome && icome <= 2420000)
            {
                taxpay = 540000 * 0.05m + (1210000 - 540000) * 0.12m + (icome - 1210000) * 0.2m;
                textBox2.Text = taxpay.ToString();
            }
            if (2420000<icome && icome <= 4530000)
            {
                taxpay = 540000 * 0.05m + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (icome-2420000) * 0.3m;
                textBox2.Text = taxpay.ToString();
            }
            if (4530000<icome && icome <= 10310000)
            {
                taxpay = 540000 * 0.05m + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m +(4530000-2420000)*0.3m+ (icome-4530000) * 0.4m;
                textBox2.Text = taxpay.ToString();
            }
            if (10310000<icome)
            {
                taxpay = 540000 * 0.05m + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (4530000 - 2420000) * 0.3m +(10310000-4530000)*0.4m +(icome-10310000) * 0.5m;
                textBox2.Text = taxpay.ToString();
            }
        }
    }
}
