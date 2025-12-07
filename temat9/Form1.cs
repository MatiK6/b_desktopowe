using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.LocationChanged += Form1_LocationChanged;
        }

        private void toolStripStatusLabel1_LocationChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel2.Text == "")
            {
                toolStripStatusLabel2.Text = "brak tekstu!";
            }
            else
            {
                toolStripStatusLabel2.Text = maskedTextBox1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text + System.Environment.NewLine
                +"x: "+this.Left.ToString()+";y:"+this.Top.ToString(),"Komunikat",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "x: " + this.Left.ToString() + "; y: " + this.Top.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
