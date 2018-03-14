using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電信費率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "中華電信  月租費350元  4元/min" + '\n' + 
                          "遠傳  月租費400元  3元/min" + '\n' + "台灣大哥大  月租費500元  2元/min";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(numericUpDown1.Value.ToString());
            int chunghwa = min * 4 + 350;
            int yuanchuan = min * 3 + 400;
            int taiwan = min * 2 + 500;
            if (chunghwa > yuanchuan || chunghwa > taiwan)
            {
                label4.Text = $"使用時間{min}分鐘，使用中華電信最省，應繳：{chunghwa}元";
            }
            else if(yuanchuan>chunghwa||yuanchuan>taiwan)
            {
                label4.Text= $"使用時間{min}分鐘，使用遠傳最省，應繳：{yuanchuan}元";
            }
            else if (taiwan > chunghwa || taiwan > yuanchuan)
            {
                label4.Text = $"使用時間{min}分鐘，使用台灣大哥大最省，應繳：{taiwan}元";
            }
            else if (chunghwa == yuanchuan)
            {
                label4.Text = $"使用時間{min}分鐘，使用中華電信與遠傳最省(費率相同)，應繳：{chunghwa}元";
            }
            else if (taiwan == yuanchuan)
            {
                label4.Text = $"使用時間{min}分鐘，使用台灣大哥大與遠傳最省(費率相同)，應繳：{taiwan}元";
            }
            else if (chunghwa == taiwan)
            {
                label4.Text = $"使用時間{min}分鐘，使用中華電信與台灣大哥大最省(費率相同)，應繳：{chunghwa}元";
            }
        }
    }
}
