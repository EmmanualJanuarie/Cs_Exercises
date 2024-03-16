using System;

//fabricating the class


//creating input for user to enter the first value
Console.WriteLine("Please enter your first number:");
string? strVal1 = Console.ReadLine();

//creating input for user to enter the Second value
Console.WriteLine("Please enter your Second number:");
string? strVal2 = Console.ReadLine();


//Converting the values to int
if(int.TryParse(strVal1, out int intVal1)
 && int.TryParse(strVal2, out int intVal2))
{
    //Calling the sum method
    Console.WriteLine("Result: " +
    Sum(intVal1, intVal2));
}else
{
    Console.WriteLine("Please enter a numeric value");
}

static int Sum(int Val1, int Val2)
{
    return Val1 + Val2;
}


