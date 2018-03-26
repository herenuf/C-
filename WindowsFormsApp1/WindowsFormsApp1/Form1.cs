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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);//输入
            double result = Math.Sqrt(a);//输出
            label1.Text = a +"的平方根是" + result.ToString();//计算
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
