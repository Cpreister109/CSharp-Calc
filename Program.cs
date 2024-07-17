using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Net;

namespace calcshortforcalculator
{
    class Calculate 
    {
        public static void Main(string[] args)
        {
            int status = 0;
            Calculate calculator = new Calculate();
            calculator.Start(0);

            while (status != 1){

                Console.WriteLine("--------------------------------------------------");
                status = 1;

            }
        }

        public void Start(float total){

            Calculate calculator = new Calculate();

            Console.WriteLine("Welcome! What would you like to solve?");
            Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
            string input_string = Console.ReadLine();
            Console.WriteLine("Which numbers would you like to " + input_string + " (EX:1 2):");
            string numbers = Console.ReadLine();
            total = calculator.solve(total, numbers, input_string);
            Console.WriteLine($"The answer is: {total}");
        }

        public void repeat(float total){

            Calculate calculator = new Calculate();

            Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
            string input_string = Console.ReadLine();
            Console.WriteLine($"Which number would you like to {input_string} to your total ({total}):");
            string numbers = Console.ReadLine();
            total = calculator.solve(total, numbers, input_string);
            Console.WriteLine($"The answer is: {total}");
        }

        public float solve(float total, string numbers, string input_string){
            
            int status = 0;
            Calculate calculator = new Calculate();

            try
            {
                string[] numbersList = numbers.Split();
                float one = float.Parse(numbersList[0]);
                float two = float.Parse(numbersList[1]);
                char sym = input_string[0];

                if (sym == '+'){
                    total = calculator.add(one, two);
                    return total;
                }
                else if(sym == '-'){
                    total = calculator.sub(one, two);
                    return total;
                }
                else if(sym == '*'){
                    total = calculator.mult(one, two);
                    return total;
                }
                else if(sym == '/'){
                    total = calculator.div(one, two);
                    return total;
                }
                else if(sym == '!'){
                    Console.WriteLine("Shutting down...");
                    return status;
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                
                return status;
        }

        public float add(float n1, float n2){
            return n1 + n2;
        }

        public float sub(float n1, float n2){
            return n1 - n2;
        }

        public float mult(float n1, float n2){
            return n1 * n2;
        }

        public float div(float n1, float n2){
            return n1 / n2;
        }
    }
}
