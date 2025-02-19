using System;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace RPN
{
    public partial class Form1 : Form
    {

        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {

            string input = inputText.Text;
            ClearInputText();

            if (ArrayButton.Checked) // if ArrayButton is True (toggled)
            {
                stack = new ArrayStack<double>(input.Length); // create a new stack object the size of the input, the stack can never be full this way
                calculator = new PolishNotationCalculator(stack); // create a new PNC object, with the ArrayStack as the implementation

            }else if (LinkedListButton.Checked) // if LinkedListButton is True (toggled)
            {
                stack = new LinkedListStack<double>();
                calculator = new PolishNotationCalculator(stack); // create a new PNC object, with the ArrayStack as the implementation

            }


            try
            {
                outputText.Text = $"Answer = {calculator.Evaluate(input.ToString())}"; // call the PNC calculator Method with the input as the argument, inside the PNC class
                ClearInputText();

            }
            catch (Exception ex)
            {
                string err = "Please make sure you type at least TWO numbers followed by the Operators";
                outputText.Text = $"{err}" + Environment.NewLine + $"{ex.Message}";
                ClearInputText();

            }

        }

        private void ClearInputText()
        {
            inputText.Text = "";
        }



    }
}
