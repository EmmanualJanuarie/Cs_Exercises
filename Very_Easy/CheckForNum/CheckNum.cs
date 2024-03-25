using System;
using System.Transactions;

namespace lang_fundamentals
{
    class CheckNum
    {
    static void Main(string[] args)
        {
            try
            {
                //creating a global variable
                Console.WriteLine("Enter a value: ");
                String str_Num = Console.ReadLine();
                //converting to int num
                if(int.TryParse(str_Num, out int int_Num))
                {
                    //printing to the terminal 
                    Console.WriteLine("Entered value is: " + int_Num);
                }else if(!int.TryParse(str_Num,out _))
                {
                    throw new Exception("Please enter a number Not a string!");
                }
            }
            catch (Exception e)
            {
                 Console.WriteLine("Error message: " + e.Message);
            }
        }

    }
}