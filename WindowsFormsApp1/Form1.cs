using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Vasya = new int[3, 3];
            int a = Vasya.Length;
            int b;
            if (a % 2 == 1)
            {
                a = (a / 2);
                label1.Text=a.ToString();
            }
            else
            {
                a = (a / 2);
                b = a ;
                a = a - 1;
                label1.Text = (a.ToString() + " и " + b.ToString());
            }
        }
    }
}
