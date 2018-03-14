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
    public partial class 查詢加油紀錄 : Form
    {
        public 查詢加油紀錄()
        {
            InitializeComponent();
            Records();
        }
        private void Records()
        {
            var context = new ContactsModel();
            var list = context.ContactTable.ToList();
            dataGridView1.DataSource = list;
            var min = list.Min((x) => x.Liter);
            var max = list.Max((x) => x.Liter);
            var MAX = list.Max((x) => x.Kilometer);
            var A = MAX / (max - min);
            label3.Text = $"每公升的平均油耗(公里公升)：{A}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.ContactTable.ToList();
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            var check = list.Where((x) => x.RefuelingDate >= date1 && x.RefuelingDate <= date2);
            dataGridView1.DataSource = check.ToList();
            var min = check.Min((x) => x.Liter);
            var max = check.Max((x) => x.Liter);
            var MAX = check.Max((x) => x.Kilometer);
            var A = MAX / (max - min);
            label3.Text = $"每公升的平均油耗(公里公升)：{A}";
        }

    }
}
