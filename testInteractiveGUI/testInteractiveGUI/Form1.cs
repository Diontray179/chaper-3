using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double Total;
            double avg;

            Total = Convert.ToDouble(txtScore1.Text) + Convert.ToDouble(txtScore2.Text) +
                Convert.ToDouble(txtScore3.Text) + Convert.ToDouble(txtScore4.Text) +
                Convert.ToDouble(txtScore5.Text);

            avg = Total / 5;

            lblresult.Text = "Averge score is: " + avg;
        }
    }
}
