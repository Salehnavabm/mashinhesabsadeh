using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashinhesabsadeh
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

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    double n1 = Convert.ToDouble(textBox1.Text);
                    double n2 = Convert.ToDouble(textBox2.Text);
                    double s = n1 + n2;
                    MessageBox.Show("sum is: " + s.ToString());
                }
                else
                {
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("عدد اول را وارد کنید");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    double n1 = Convert.ToDouble(textBox1.Text);
                    double n2 = Convert.ToDouble(textBox2.Text);
                    double t = n1 / n2;
                    MessageBox.Show("taghsim: " + t.ToString());
                }
                else
                {
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("عدد اول را وارد کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    double n1 = Convert.ToDouble(textBox1.Text);
                    double n2 = Convert.ToDouble(textBox2.Text);
                    double p = n1 * n2;
                    MessageBox.Show("zarb: " + p.ToString());
                }
                else
                {
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("عدد اول را وارد کنید");
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    double n1 = Convert.ToDouble(textBox1.Text);
                    double n2 = Convert.ToDouble(textBox2.Text);
                    double m = n1 - n2;
                    MessageBox.Show("menha: " + m.ToString());
                }
                else
                {
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("عدد اول را وارد کنید");
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}