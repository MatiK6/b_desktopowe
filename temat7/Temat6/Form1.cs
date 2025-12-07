namespace Temat6
{
    public partial class Form1 : Form
    {
        byte dzialanie =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Text)
                {
                    case "+": dzialanie = 1; break;
                    case "-": dzialanie = 2; break;
                    case "*": dzialanie = 3; break;
                    case "/": dzialanie = 4; break;
                    default: dzialanie = 0; break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float wynik = 0;

            switch (dzialanie)
            {
                case 1: wynik = a + b; break;
                case 2: wynik = b - a; break;
                case 3: wynik = a * b; break;
                case 4: wynik = b / a; break;
                default: wynik = 0; break;
            }
            label3.Text = wynik.ToString();

        }
    }
}
