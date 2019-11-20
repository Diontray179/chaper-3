using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class txt_entry1 : Form
    {
        public txt_entry1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int num1;
          int num2;


          int sum;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(txt_entry2.Text);

            sum = num1 + num2;

            lbl_result.Text = "sum is " + sum;
        }
    }
}
