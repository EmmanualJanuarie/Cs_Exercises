//this program is to convert mins into seconds

using System;
using System.Numerics;

namespace Math
{
    class ToSecs
    {
       
        static void Main(string[] args)
        {
        //Creating the input for the first number
        Console.WriteLine("Please enter the amount of minutes, to convert to seconds");
        string? strMins = Console.ReadLine();

        //converting string value to integer
        if(int.TryParse(strMins, out int intMins))
        {
            //Console to call method
            Console.WriteLine("Result: " + MinsTosecs(intMins) + " " + "seconds");
        }else
        {
            Console.WriteLine("Please enter a numeric value!");
        }

        }
          //creating a method that will convert mins to secs
        static int MinsTosecs(int intMins)
        {
            return intMins * 60;
        }
        
    }
}