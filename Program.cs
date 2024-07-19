using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Net;
using System.Numerics;

namespace calcshortforcalculator
{
    class Calculate 
    {
        public static void Main(string[] args)
        {
            float status = 0;
            Calculate calculator = new Calculate();
            float total = calculator.Start(0);
            status = total;

            while (status != 'q'){

                Console.WriteLine("--------------------------------------------------");
                status = calculator.repeat(total);
                total = status;

            }
        }

        public float Start(float total){

            Calculate calculator = new Calculate();

            Console.WriteLine("Welcome! What would you like to solve?");
            Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
            string input_string = Console.ReadLine();

            if(input_string.Contains("!")){
                Console.WriteLine("Shutting down...");
                return 'q';}

            Console.WriteLine("Which numbers would you like to " + input_string + " (EX:1 2):");
            string numbers = Console.ReadLine();
            total = calculator.solve(total, numbers, input_string);
            Console.WriteLine($"The answer is: {total}");
            return total;
        }

        public float repeat(float total){

            Calculate calculator = new Calculate();

            Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");
            string input_string = Console.ReadLine();

            if(input_string.Contains("!")){
                Console.WriteLine("Shutting down...");
                return 'q';}
            
            Console.WriteLine($"Which number would you like to {input_string} to your total ({total}):");
            string number = Console.ReadLine();
            total = calculator.solve(total, number, input_string);
            Console.WriteLine($"The answer is: {total}");
            return total;
        }

        public float solve(float total, string numbers, string input_string){
            
            int status = 0;
            Calculate calculator = new Calculate();

            try
            {
                float one;
                float two;
                char sym = input_string[0];

                if (numbers.Contains(" ")){
                    string[] numbersList = numbers.Split();
                    one = float.Parse(numbersList[0]);
                    two = float.Parse(numbersList[1]);
                }
                else{
                    one = total;
                    two = float.Parse(numbers);
                }


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
