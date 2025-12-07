using System;
using System.Windows.Forms;
namespace Temat2
{
    public partial class Form1 : Form
    {



        int licznik = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            licznik++;
            label2.Text = "Suma kliknięć: " + licznik.ToString();
        }
    }
}
