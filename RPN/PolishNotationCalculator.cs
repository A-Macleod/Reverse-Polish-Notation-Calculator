using System;

namespace RPN
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;
                                                        
        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {
             /*
             * 1. Split the expression into individual tokens using a space as the delimiter.
             * 2. Iterate over each token:
             *      - If the token is a number, push it onto the stack.
             *      - If the token is an operator (+, -, *, /):
             *          a. Pop two numbers from the stack (b first, then a).
             *          b. Perform the operation (a + b, a - b, etc.).
             *          c. Push the result back onto the stack.
             * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */

            string[] tokens = expression.Trim().Split(' '); // trim the whitespace and seperate inputs with a space

           

            for(int i = 0; i < tokens.Length; i++)                      // iterate over the entire expression array
            {

                if (double.TryParse(tokens[i], out double result))      // if the index is a number, output to result
                {

                    stack.Push(result);                                 // push the number to the stack

                }
                else if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    double b = stack.Pop();     // return b and remove from stack
                    double a = stack.Pop();     // return a and remove from stack

                    if (tokens[i] == "/")
                    {
                        if(b == 0)
                        {
                            throw new Exception(Environment.NewLine + "You can not divide by Zero");
                        }

                        stack.Push(a / b);
                    }

                    if (tokens[i] == "*")
                    {
                        stack.Push(a * b);
                    }

                    if (tokens[i] == "+")
                    {
                        stack.Push(a + b);     
                    }

                    if(tokens[i] == "-")
                    {
                        stack.Push(a - b);
                    }

                }
                else
                {
                    throw new InvalidOperationException(Environment.NewLine + "The expression input has invalid parameters" );
                }

            }

            return stack.Pop(); // return and remove the top value, which is the answer

        } // EO Evaluate

    }
}
