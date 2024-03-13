namespace may_tinh
{
    public partial class Form1 : Form
    {
        private void handle_operator_click(object sender, EventArgs e)
        { 
        Button button = sender as Button;
            string operator_Value = button.Text;
            if (is_choosen)
            {
                after_string = after_string + button.Text;
            }
            else { 
            before_string = before_string + button.Text;
            textBox1.Text = before_string;
            }
        }
        private void ResetValue()
        {
            is_choosen = false;
            operator_value = " ";
            after_string = " ";
            before_string= " ";
        }
        public Form1()
        {
            InitializeComponent();
            button1.Click += button10_Click;
            button2.Click += button10_Click;
            button3.Click += button10_Click;
            button4.Click += button10_Click;
            button5.Click += button10_Click;
            button6.Click += button10_Click;
            button7.Click += button10_Click;
            button8.Click += button10_Click;
            button9.Click += button10_Click;
        }
        string before_string = " ";
        string after_string = " ";
        string operator_value = " ";
        bool is_choosen = false;
        float result;
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            string buttonText = button1.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button1.Text;

            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = sender as Button;
            string buttonText = button2.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button2.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button3 = sender as Button;
            string buttonText = button3.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button3.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button11 = sender as Button;
            string buttonText = button11.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button11.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button4 = sender as Button;
            string buttonText = button4.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button4.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button5 = sender as Button;
            string buttonText = button5.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button5.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button6 = sender as Button;
            string buttonText = button6.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button6.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button12 = sender as Button;
            string buttonText = button12.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button12.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button7 = sender as Button;
            string buttonText = button7.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button7.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button9 = sender as Button;
            string buttonText = button9.Text;
            if (is_choosen)
            {
                textBox1.Text = "";
                after_string = after_string + button9.Text;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(before_string);
            int number2 = int.Parse(after_string);
            int result;
            switch(operator_value)
            {
                case "+":
                    {
                        result = number1 + number2;
                        break;
                    }
                    default: 
                    {
                        result = 0; break;
                    }
                case "-":
                    {
                        result = number1 - number2;
                        break;
                    }
               
                case "*":
                    {
                        result = number1 * number2;
                        break;
                    }
                
                case "/":
                    {
                        result = number1 * number2;
                        break;
                    }


            }
            textBox1.Text += number1;
            ResetValue();
        }
    }
}
