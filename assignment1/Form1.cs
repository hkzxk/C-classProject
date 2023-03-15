using System.Security.Cryptography.X509Certificates;

namespace calculator_WinForms
{

    public partial class Form1 : Form
    {
        
        string oprt;
        double opera_1;
        double opera_2;
        string[] ss;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oprt == "+") {
                ss = textBox1.Text.Split("+");
                opera_2 = double.Parse(ss[1]);
                textBox1.Text = Convert.ToString(opera_1 + opera_2);
            }
            if (oprt == "-")
            {
                ss = textBox1.Text.Split("-");
                opera_2 = double.Parse(ss[1]);
                textBox1.Text = Convert.ToString(opera_1 - opera_2);
            }
            if (oprt == "*")
            {
                ss = textBox1.Text.Split("*");
                opera_2 = double.Parse(ss[1]);
                textBox1.Text = Convert.ToString(opera_1 * opera_2);
            }
            if (oprt == "/")
            {
                ss = textBox1.Text.Split("/");
                opera_2 = double.Parse(ss[1]);
                textBox1.Text = Convert.ToString(opera_1 / opera_2);
            }
            if (oprt == "^")
            {
                ss = textBox1.Text.Split("^");
                opera_2 = double.Parse(ss[1]);
                textBox1.Text = Convert.ToString(Math.Pow(opera_1,opera_2));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            opera_1 = 0;
            opera_2 = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opera_1 = double.Parse(textBox1.Text);
            oprt = "+";
            textBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            opera_1 = double.Parse(textBox1.Text);
            oprt = "-";
            textBox1.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opera_1 = double.Parse(textBox1.Text);
            oprt = "*";
            textBox1.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opera_1 = double.Parse(textBox1.Text);
            oprt = "/";
            textBox1.Text += " / ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            opera_1 = double.Parse(textBox1.Text);
            oprt = "^";
            textBox1.Text += "^";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
}
