namespace lab1
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int count;
        char sign;
        string display;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "KKU";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sign = '+';
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = '-';
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = '*';
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sign = '/';
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);
            if (sign == '+')
            {
                count = num1 + num2;
                display = Convert.ToString(count);
                textBox1.Text = display;
            }
            if (sign == '-')
            {
                count = num1 - num2;
                display = Convert.ToString(count);
                textBox1.Text = display;
            }
            if (sign == '*')
            {
                count = num1 * num2;
                display = Convert.ToString(count);
                textBox1.Text = display;
            }
            if (sign == '/')
            {
                count = num1 / num2;
                display = Convert.ToString(count);
                textBox1.Text = display;
            }
        }
    }
}
