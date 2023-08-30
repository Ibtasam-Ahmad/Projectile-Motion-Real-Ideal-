using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enter value of V
            // Enter value of thetha

            double v, theta;

            v = double.Parse(textBox1.Text);
            theta = double.Parse(textBox2.Text);

            int size = 1000;
            double delta = 0.1;


            double g = 9.8;
            double[] vx = new double[size];
            double[] vy = new double[size];
            double[] x = new double[size];
            double[] y = new double[size];
            double[] t = new double[size];
            x[0] = 0;
            y[0] = 0;

            vx[0] = v * Math.Cos(theta * 3.14 / 180);
            vy[0] = v * Math.Sin(theta * 3.14 / 180);

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Brown);

            for (int i = 0; i < size-1 ; i++)
            {
                vx[i + 1] = vx[i]; 
                vy[i + 1] = vy[i] - g * delta;
                x[i + 1] = x[i] + vx[i] * delta;
                y[i + 1] = y[i] + vy[i] * delta;

                gg.FillEllipse(sb, 100 + (float)x[i], 400 - (float)y[i], 5, 5);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Enter value of V
            // Enter value of thetha

            double v, theta, m;

            v = double.Parse(textBox1.Text);
            theta = double.Parse(textBox2.Text);
            m = double.Parse(textBox3.Text);

            int size = 1000;
            double delta = 0.1;


            double g = 9.8;
            double B2 = 4*Math.Pow(10, -2.2);

            double[] vx = new double[size];
            double[] vy = new double[size];
            double[] x = new double[size];
            double[] y = new double[size];

            x[0] = 0;
            y[0] = 0;

            vx[0] = v * Math.Cos(theta * 3.14 / 180);
            vy[0] = v * Math.Sin(theta * 3.14 / 180);

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);

            for (int i = 0; i < size - 1; i++)
            {
                x[i + 1] = x[i] + (vx[i] * delta);
                y[i + 1] = y[i] + (vy[i] * delta);
                vx[i + 1] = vx[i] - (B2 * v * vx[i] * delta)/m; 
                vy[i + 1] = vy[i] - (g * delta) - (B2 * v * vy[i] * delta)/m;
        
                gg.FillEllipse(sb, 100 + (float)x[i], 400 - (float)y[i], 5, 5);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
