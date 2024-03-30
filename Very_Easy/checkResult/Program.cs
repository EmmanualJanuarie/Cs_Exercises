//creating the namespace
namespace Math_Calculations
{
    //fabricating the class
    class CheckResult
    {
        //creating the main method
        static void Main(string[] args)
        {
            //creating the input for calculation
            Console.Write("Please enter a calculation(+, -, /, *): ");
            string str_calc = Console.ReadLine();

            //calling the method
            isTwenty_Four(str_calc);
        }

    //creating the method to check if result is 24
        static void isTwenty_Four(string calc)
        {
            if(calc.Contains("*"))
            {
                //calling multiplication method
                Multiplication(calc);
            } 
            else if(calc.Contains("-"))
            {
                Subtraction(calc);
            }
            else if(calc.Contains("+"))
            {
                Addition(calc);
            }
            else if(calc.Contains("/"))
            {
                Division(calc);
            }
            else
            {
                Console.WriteLine("No operations where used ['+','-','/','*'] !");
            }
        }

        //creating a method to handle calculation for multiplication
        static void Multiplication(string calc)
        {
            //created index variable to locate index of multiplication sign
            int index = calc.IndexOf('*');

            //creating a default variable
            string str_num1 = calc.Substring(0, index); //from start index
            string str_num2 = calc.Substring(index + 1, calc.Length - index - 1 );//this allows index to start from particullar position to end index

              if(int.TryParse(str_num1, out int intNum1) && int.TryParse(str_num2, out int intNum2))
            {
                 int product = intNum1 * intNum2;

                 //conditional statement 
                  if(product == 24)
                {
                    Console.WriteLine("Multiplication");
                }else
                {
                    Console.WriteLine("None");
                }
            }
        }

        //creating a method to handle calculation for Subtraction
        static void Subtraction(string calc)
        {
             //created index variable to locate index of multiplication sign
            int index = calc.IndexOf('-');

            //creating a default variable
            string str_num1 = calc.Substring(0, index); //from start index
            string str_num2 = calc.Substring(index + 1, calc.Length - index - 1 );//this allows index to start from particullar position to end index

              if(int.TryParse(str_num1, out int intNum1) && int.TryParse(str_num2, out int intNum2))
            {
                 int difference = intNum1 - intNum2;

                 //conditional statement 
                  if(difference == 24)
                {
                    Console.WriteLine("Substraction");
                }else
                {
                    Console.WriteLine("None");
                }
            }
        }

        //creating a method to handle calculation for Addition
        static void Addition(string calc)
        {
         //created index variable to locate index of multiplication sign
            int index = calc.IndexOf('+');

            //creating a default variable
            string str_num1 = calc.Substring(0, index); //from start index
            string str_num2 = calc.Substring(index + 1, calc.Length - index - 1 );//this allows index to start from particullar position to end index

              if(int.TryParse(str_num1, out int intNum1) && int.TryParse(str_num2, out int intNum2))
            {
                 int sum = intNum1 + intNum2;

                 //conditional statement 
                  if(sum == 24)
                {
                    Console.WriteLine("Addition");
                }else
                {
                    Console.WriteLine("None");
                }
            }
        }

    //creating a method to handle calculation for Division
        static void Division(string calc)
        {
            //created index variable to locate index of multiplication sign
            int index = calc.IndexOf('/');

            //creating a default variable
            string str_num1 = calc.Substring(0, index); //from start index
            string str_num2 = calc.Substring(index + 1, calc.Length - index - 1 );//this allows index to start from particullar position to end index

              if(int.TryParse(str_num1, out int intNum1) && int.TryParse(str_num2, out int intNum2))
            {
                 int quotient = intNum1 / intNum2;

                 //conditional statement 
                  if(quotient == 24)
                {
                    Console.WriteLine("Division");
                }else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}