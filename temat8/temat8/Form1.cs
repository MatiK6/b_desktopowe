namespace temat8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag)
            {
                case "imD":
                    if (rb.Checked) textBox1.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "imM":
                    if (rb.Checked) textBox1.CharacterCasing = CharacterCasing.Lower;
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag)
            {
                case "naM":
                    if (rb.Checked) textBox2.CharacterCasing = CharacterCasing.Lower;
                    break;
                case "naD":
                    if (rb.Checked) textBox2.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "naDowolne":
                    if (rb.Checked) textBox2.CharacterCasing = CharacterCasing.Normal;
                    break;

            }




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch (cb.Tag)
            {
                case "chBox1":
                    if (cb.Checked) textBox1.Enabled = false;
                    else textBox1.Enabled = true;
                    break;
                case "chBox2":
                    textBox2.Enabled = !cb.Checked;
                    break;
                case "chBox3":
                    groupBox1.Enabled = !cb.Checked;
                    break;
                case "chBox4":
                    groupBox2.Enabled = !cb.Checked;
                    break;
            }
        }    
    }
}
