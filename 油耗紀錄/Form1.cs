﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 油耗紀錄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new 輸入加油紀錄();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new 查詢加油紀錄();
            form.ShowDialog();
        }
    }
}
