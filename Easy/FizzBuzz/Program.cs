//creating a namespace
using System.Security.Cryptography;

namespace interview_Qs
{
    //creating the class
    class FizzBuzz
    {
        //creating the main method
        static void Main(string[] args)
        {
            //creating the input variable
            Console.Write("Please enter a number: ");
            string strNum = Console.ReadLine();

            //Converting string variable to an Integer
            if(int.TryParse(strNum, out int intNum))
            {
                //calling the fizzBuzz method
                Console.WriteLine(Fizz_Buzz(intNum));
            }
            else
            {
                Console.WriteLine("Please Enter a valid number! ");
            }
            
        }

        //fabricating the FuzzBuzz Method
        static string Fizz_Buzz(int multiple)
        {
         if(multiple % 3 == 0 && multiple % 5 == 0)
         {
            return "FizzBuzz";
         }
         else if(multiple % 3 == 0)
         {
            return "Fizz";
         }
         else if(multiple % 5 == 0)
         {
            return "Buzz";
         }
         else
         {
            return $"{multiple} Not a multiple of '3' or '5'";
         }
        }

    }
}