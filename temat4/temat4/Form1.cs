namespace temat4
{
    public partial class Form1 : Form
    {

        private int a = 0, b = 0, wynik = 0, reszta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            wynik = a + b;

            label3.Text = $"Wynik to: {wynik.ToString()}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            wynik = a - b;

            label3.Text = $"Wynik to: {wynik.ToString()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            wynik = a * b;

            label3.Text = $"Wynik to: {wynik.ToString()}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (b != 0)
            {

                label3.Text = $"Wynik to: {a / b}";

            }
            else
            {
                label3.Text = "Nie mo¿na dzieliæ przez 0";

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (b != 0)
            {

                label3.Text = $"Wynik to: {a % b}";

            }
            else
            {
                label3.Text = "Nie mo¿na dzieliæ przez 0";

            }
        }
    }
}
