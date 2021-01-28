using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fun();
        }

        private void fun() {

            Task<int> task1 = ShowStatus();
            //ShowStatus();
            Thread.Sleep(5000);
        }
        private async Task<int> ShowStatus() {
            label1.Text = "=== Processing ====";
            return 1;
        }
    }
}
