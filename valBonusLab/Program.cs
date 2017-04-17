using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valBonusLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string Prompt = "";
            int Min = 1;
            int Max = 100;
             
           // Console.WriteLine(GetInt(Prompt));
            Console.WriteLine(GetIntWithinRange(Prompt,Min, Max));
        }


        public static int GetInt(string Prompt)
             
        { while (true)
            {
                Console.WriteLine("please enter a valid integer");
                string userInput;
                int newInput;
                userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out newInput))
                {

                    Console.WriteLine("not an integer, please enter valid integer");
                }

                else
                {
                    return newInput;
                }
            }  
                

               
                

        
        }

        public static int GetIntWithinRange(string Prompt, int Min, int Max)
        {
            while (true) 
            {
                int min = 1;
                int max = 100;
                Console.WriteLine("please enter a number between 1 and 100");
                string userInput;

                int newInput;
                userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out newInput))
                {

                    Console.WriteLine("not an integer, please enter valid integer");
                }

                else if (newInput < min || newInput > max)
                {
                    Console.WriteLine("ERROR, PLEASE ENTER A NUMBER BETWEEN 1 AND 100");
                }
                else
                {
                    return newInput;
                }

            }
                



        }
    }
}
