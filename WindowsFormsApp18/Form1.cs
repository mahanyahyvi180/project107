using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int count = 2;
            while (count <= Math.Sqrt(x))
            {
                if (x % count == 0)
                {
                    lable3.Text = "the number is not prime";
                    return;
                }
                lable3.Text = "the number is prime";
            }

                

        }
    }
}
