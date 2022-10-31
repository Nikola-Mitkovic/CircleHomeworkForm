using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleHomeworkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius, area, circumference;
            radius = Convert.ToDouble(txtRadius.Text);
            
            area = 3.14 * (radius * radius);
            circumference = 2 * 3.14 * radius;

            lblArea.Text = area.ToString();
            lblCircumference.Text = circumference.ToString();
        }
    }
}
