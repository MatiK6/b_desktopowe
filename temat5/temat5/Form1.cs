namespace temat5
{
    public partial class Form1 : Form
    {

        float a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = float.Parse(textBox1.Text);

            if (a > 0)
            {
                label3.Text = "Liczba a = " + a.ToString() + " jest dodatnia";
            }
            else if (a < 0)
            {
                label3.Text = "Liczba a = " + a.ToString() + " jest ujemna";
            }
            else
            {
                label3.Text = "Liczba a = " + a.ToString() + " jest równa zeru";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);

            b = float.Parse(textBox2.Text);

            if (a > b)
            {
                label3.Text = a.ToString() + " jest wiêksze od " + b.ToString();
            }
            else if (a < b)
            {
                label3.Text = a.ToString() + " jest mniejsze od " + b.ToString();
            }
            else
            {
                label3.Text = a.ToString() + " jest równe " + b.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);

            b = float.Parse(textBox2.Text);

            if (b != 0)
            {
                c = a / b;
                label3.Text = a.ToString() + "/" + b.ToString() + "=" + c.ToString();

            }
            else
            {
                label3.Text = "Dzielenie jest niemo¿liwe";
            }
        }
    }
}
