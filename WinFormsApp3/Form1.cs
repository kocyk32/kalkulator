namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }

        private void bdzielenie_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Obliczenia();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void bmnozenie_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Obliczenia();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void bodejmowanie_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Obliczenia();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void bdodawanie_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Obliczenia();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;

        }

        private void bwynik_Click(object sender, EventArgs e)
        {
            Obliczenia();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            wynik.Text = "";

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            wynik.Text = currentInput;
        }
        private void Obliczenia()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "x":
                        result *= secondNumber;
                        break;
                    case "÷":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            wynik.Text = "Error";
                            return;
                        }
                        break;
                }

                wynik.Text = result.ToString();
                currentInput = "" + "";
                operationPending = false;
            }
        }

        private void kalkulator_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
