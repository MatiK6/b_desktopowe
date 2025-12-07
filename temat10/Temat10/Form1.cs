namespace Temat10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult wynik = MessageBox.Show("Czy zakoñczyæ aplikacjê?", "Komunikat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wynik == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Text = "Rezygnacja z zamkniêcia";
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
