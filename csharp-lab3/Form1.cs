using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_lab3
{
    public partial class Form1 : Form
    {

        Vector a = new Vector();
        Vector b = new Vector();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.X = Convert.ToInt32(textBox1.Text);
            a.Y = Convert.ToInt32(textBox2.Text);
            a.Z = Convert.ToInt32(textBox3.Text);
            b.X = Convert.ToInt32(textBox4.Text);
            b.Y = Convert.ToInt32(textBox5.Text);
            b.Z = Convert.ToInt32(textBox6.Text);

            richTextBox1.Text = a.ToString() + b.ToString();
            
       
        }
    }
}
