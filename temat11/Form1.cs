namespace Zad11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(sizeof(float)) + " B";
            label1.Text += "   min: " + float.MinValue.ToString() +
                           "   max: " + float.MaxValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Typ: " + comboBox2.Text + "; rozmiar: ";

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    label1.Text = s + Convert.ToString(sizeof(bool)) + " B";
                    break;

                case 1:
                    label1.Text = s + Convert.ToString(sizeof(byte)) + " B; min: "
                                  + byte.MinValue.ToString() + ", max: "
                                  + byte.MaxValue.ToString();
                    break;

                case 2:
                    label1.Text = s + Convert.ToString(sizeof(char)) + " B; min: "
                                  + char.MinValue.ToString() + ", max: "
                                  + char.MaxValue.ToString();
                    break;

                case 3:
                    label1.Text = s + Convert.ToString(sizeof(decimal)) + " B; min: "
                                  + decimal.MinValue.ToString() + ", max: "
                                  + decimal.MaxValue.ToString();
                    break;

                case 4:
                    label1.Text = s + Convert.ToString(sizeof(double)) + " B; min: "
                                  + double.MinValue.ToString() + ", max: "
                                  + double.MaxValue.ToString();
                    break;

                case 5:
                    label1.Text = s + Convert.ToString(sizeof(float)) + " B; min: "
                                  + float.MinValue.ToString() + ", max: "
                                  + float.MaxValue.ToString();
                    break;

                case 6:
                    label1.Text = s + Convert.ToString(sizeof(int)) + " B; min: "
                                  + int.MinValue.ToString() + ", max: "
                                  + int.MaxValue.ToString();
                    break;

                case 7:
                    label1.Text = s + Convert.ToString(sizeof(long)) + " B; min: "
                                  + long.MinValue.ToString() + ", max: "
                                  + long.MaxValue.ToString();
                    break;

                case 8:
                    label1.Text = s + Convert.ToString(sizeof(sbyte)) + " B; min: "
                                  + sbyte.MinValue.ToString() + ", max: "
                                  + sbyte.MaxValue.ToString();
                    break;

                case 9:
                    label1.Text = s + Convert.ToString(sizeof(short)) + " B; min: "
                                  + short.MinValue.ToString() + ", max: "
                                  + short.MaxValue.ToString();
                    break;

                case 10:
                    label1.Text = s + Convert.ToString(sizeof(uint)) + " B; min: "
                                  + uint.MinValue.ToString() + ", max: "
                                  + uint.MaxValue.ToString();
                    break;

                case 11:
                    label1.Text = s + Convert.ToString(sizeof(ulong)) + " B; min: "
                                  + ulong.MinValue.ToString() + ", max: "
                                  + ulong.MaxValue.ToString();
                    break;

                case 12:
                    label1.Text = s + Convert.ToString(sizeof(ushort)) + " B; min: "
                                  + ushort.MinValue.ToString() + ", max: "
                                  + ushort.MaxValue.ToString();
                    break;
            }

        }


    }
}

