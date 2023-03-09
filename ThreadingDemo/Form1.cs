using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_process1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("işlem 1 çalıştı");
        }

        private void btn_process2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("işlem 2 çalıştı");
        }
    }
}
