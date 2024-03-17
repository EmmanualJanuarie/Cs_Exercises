using System;
//~This program is created to increment the useres entry by 1

//creating the namespace
namespace Math
{
    //Fabricating a class
    class IncrementBy1
    {
        //creating the "Main" method
        static void Main(string[] args)
        {
            //create the variable to allow user to enter a value
            Console.WriteLine("Please enter a value:");
            string? strNum = Console.ReadLine();

            //converting the string num to int
            if(int.TryParse(strNum, out int intNum))
            {
                //return to the console the value
                Console.WriteLine("Result:" + By1(intNum));
            }
        }


        //creating a method to handle the incrementation
        static int By1(int intNum)
        {
            return intNum + 1;
        }
    }
}
