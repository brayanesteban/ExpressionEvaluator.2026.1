using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text += "0";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "^";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "-";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "(";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textDisplay.Text += ")";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textDisplay.Text += $"={Evaluator.Evaluate(textDisplay.Text)}";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textDisplay.Text = string.Empty;
        }
    }
}
