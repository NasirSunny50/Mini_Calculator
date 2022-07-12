using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int result =  int.Parse(textBox_first.Text) + int.Parse(textBox_second.Text);
            textBox_result.Text = result.ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox_first.Text) - int.Parse(textBox_second.Text);
            textBox_result.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox_first.Text) * int.Parse(textBox_second.Text);
            textBox_result.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            float result = float.Parse(textBox_first.Text) / float.Parse(textBox_second.Text);
            textBox_result.Text = result.ToString();
        }
    }
}
