using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 油耗紀錄.Models;

namespace 油耗紀錄
{
    public partial class 輸入加油紀錄 : Form
    {
        public 輸入加油紀錄()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ContactTable data = new ContactTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter=Convert.ToDouble(numericUpDown1.Value),
                Kilometer=Convert.ToDouble(numericUpDown2.Value)
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.ContactTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
