namespace OverloadFraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f;
            Fraction.TryParse(textBox1.Text, out f);
            if (f != null)
            {
                listBox1.Items.Add(f);
            }
            else
            {
                MessageBox.Show("This is not a fraction");
            }
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction(0, 1);
            foreach (Fraction item in listBox1.Items)
            {
                f1 = f1 + item;
            }
            label1.Text = f1.ToString();

        }
    }
}
