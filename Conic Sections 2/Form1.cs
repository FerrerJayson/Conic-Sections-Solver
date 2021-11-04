using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conic_Sections_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox3.Text);
            double D = Convert.ToDouble(textBox4.Text);
            double E = Convert.ToDouble(textBox5.Text);
            double F = Convert.ToDouble(textBox6.Text);
            double G, H, I, J, K; 
            if (A == C)
            {
                G = D / -2;
                H = E / -2;
                textBox7.Text = Convert.ToString(G);
                textBox8.Text = Convert.ToString(H);
                textBox9.Text = Convert.ToString(G);
                textBox10.Text = Convert.ToString(H);
                textBox11.Text = Convert.ToString(Math.Sqrt((G * G) + (H * H) - F));
                textBox12.Text = Convert.ToString(Math.Sqrt((G * G) + (H * H) - F));
                textBox13.Text = "Circle";
                textBox14.Text = "Infinite";
                textBox15.Text = "Infinite";
            }
            else if (A==0^C==0)
            {
                if (C==0)
                {
                    G = D / -2;
                    H = (F - (G * G)) / -E;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox9.Text = Convert.ToString(G);
                    textBox10.Text = Convert.ToString(H + (E/-4));
                    textBox11.Text = "N/A";
                    textBox12.Text = "N/A";
                    textBox13.Text = "Parabola";
                    textBox14.Text = "R";
                    textBox15.Text = Convert.ToString(H - (E / -4));
                }
                else if (A==0)
                {
                    H = E / -2;
                    G = (F - (H * H)) / -D;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox7.Text = Convert.ToString(G + (D / -4));
                    textBox8.Text = Convert.ToString(H);
                    textBox11.Text = "N/A";
                    textBox12.Text = "N/A";
                    textBox13.Text = "Parabola";
                    textBox14.Text = Convert.ToString(G - (D / -4));
                    textBox15.Text = "R";
                }
                
            }
            else if ((A!=C)&&(A*C>0))
            {
                if (Math.Abs(C) > Math.Abs(A))
                {
                    G = D / (-2 * A);
                    H = E / (-2 * C);
                    I = C - A;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox9.Text = Convert.ToString(G + Math.Sqrt(I));
                    textBox10.Text = Convert.ToString(H);
                    textBox11.Text = Convert.ToString(Math.Sqrt(C));
                    textBox12.Text = Convert.ToString(Math.Sqrt(A));
                    textBox13.Text = "Ellipse";
                    textBox14.Text = Convert.ToString(C / Math.Sqrt(I));
                    textBox15.Text = "R";
                    textBox16.Text = Convert.ToString(G - Math.Sqrt(I));
                    textBox17.Text = Convert.ToString(H);
                }
                else if (Math.Abs(C) < Math.Abs(A))
                {
                    G = D / (-2 * A);
                    H = E / (-2 * C);
                    I = A - C;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox9.Text = Convert.ToString(G);
                    textBox10.Text = Convert.ToString(H + Math.Sqrt(I));
                    textBox11.Text = Convert.ToString(Math.Sqrt(C));
                    textBox12.Text = Convert.ToString(Math.Sqrt(A));
                    textBox13.Text = "Ellipse";
                    textBox14.Text = "R";
                    textBox15.Text = Convert.ToString(C / Math.Sqrt(I));
                    textBox16.Text = Convert.ToString(G);
                    textBox17.Text = Convert.ToString(H - Math.Sqrt(I));
                }
            }
            else if ((A!=C)&&(A*C<0))
            {
                if (Math.Abs(C) > Math.Abs(A))
                {
                    G = D / (-2 * A);
                    H = E / (-2 * C);
                    I = A + C;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox9.Text = Convert.ToString(G + Math.Sqrt(I));
                    textBox10.Text = Convert.ToString(H);
                    textBox11.Text = "N/A";
                    textBox12.Text = "N/A";
                    textBox13.Text = "Hyperbola";
                    textBox14.Text = Convert.ToString(C / Math.Sqrt(I));
                    textBox15.Text = "R";
                    textBox16.Text = Convert.ToString(G - Math.Sqrt(I));
                    textBox17.Text = Convert.ToString(H);
                }
                else if (Math.Abs(C) < Math.Abs(A))
                {
                    G = D / (-2 * A);
                    H = E / (-2 * C);
                    I = A + C;
                    textBox7.Text = Convert.ToString(G);
                    textBox8.Text = Convert.ToString(H);
                    textBox9.Text = Convert.ToString(G);
                    textBox10.Text = Convert.ToString(H + Math.Sqrt(I));
                    textBox11.Text = "N/A";
                    textBox12.Text = "N/A";
                    textBox13.Text = "Hyperbola";
                    textBox14.Text = "R";
                    textBox15.Text = Convert.ToString(C / Math.Sqrt(I));
                    textBox16.Text = Convert.ToString(G);
                    textBox17.Text = Convert.ToString(H - Math.Sqrt(I));
                }
            }
        }
    }
}
