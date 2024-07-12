using System.ComponentModel;
using System.Data.Common;
using System.Net;

namespace calcshortforcalculator
{
    class Calculate 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What would you like to solve?");
            int status = 0;
            float total = 0;

            while (status != 1){

                Console.WriteLine("+) Addition\n-) Subtraction\n*) Multiplication\n/) Division\n!) Quit");

                string input_string = Console.ReadLine();
                char input = input_string[0];

                if (input == '+'){

                }
                else if(input == '-'){

                }
                else if(input == '*'){

                }
                else if(input == '/'){

                }
                else if(input == '!'){
                    Console.WriteLine("Shutting down...");
                    status = 1;
                }

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
