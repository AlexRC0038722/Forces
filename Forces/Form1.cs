using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }

        double atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Read values from textboxes
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            // calculate Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            // put values for Fx and Fy in labels
            label1.Text = "Fx = " + Fx + "N";
            label2.Text = "Fy = " + Fy + "N";
        }
    }
}
