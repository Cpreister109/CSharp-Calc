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
            Console.WriteLine("Welcome! What would you like to solve?");
            Calculate calculator = new Calculate();
            int status = 0;

            while (status != 1){

                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
                string input_string = Console.ReadLine();
                Console.WriteLine("Which numbers would you like to " + input_string + " (EX:1 2):");
                string numbers = Console.ReadLine();

                try
                {
                    string[] numbersList = numbers.Split();
                    float one = float.Parse(numbersList[0]);
                    float two = float.Parse(numbersList[1]);
                    char sym = input_string[0];
                    float total = 0;

                if (sym == '+'){
                    total = calculator.add(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '-'){
                    total = calculator.sub(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '*'){
                    total = calculator.mult(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '/'){
                    total = calculator.div(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '!'){
                    Console.WriteLine("Shutting down...");
                    status = 1;
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public void repeat(float total){

            int status = 0;

            Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
            string input_string = Console.ReadLine();
            Console.WriteLine($"Which number would you like to {input_string} to your total ({total}):");
            string numbers = Console.ReadLine();
            Calculate calculator = new Calculate();

            try
                {
                    string[] numbersList = numbers.Split();
                    float one = float.Parse(numbersList[0]);
                    float two = float.Parse(numbersList[1]);
                    char sym = input_string[0];

                if (sym == '+'){
                    total = calculator.add(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '-'){
                    total = calculator.sub(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '*'){
                    total = calculator.mult(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '/'){
                    total = calculator.div(one, two);
                    Console.WriteLine($"The answer is: {total}");
                }
                else if(sym == '!'){
                    Console.WriteLine("Shutting down...");
                    status = 1;
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
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
