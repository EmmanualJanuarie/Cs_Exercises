//creating namespace for Hamming Distance
namespace language_Fundamentals
{
    //creating class
    class HammingDistance
    {
        //fabricating the Main Method
        static void Main(string[] args)
        {
            //creating input variable for first string entry
            Console.Write("Please enter first string value:");
            string str_Val1 = Console.ReadLine();  

            //creating input variable for second string entry
             Console.Write("Please enter second string value:");
            string str_Val2 = Console.ReadLine();

            //calling Hamming Distance method
            Console.Write(Hamming_Distance(str_Val1,str_Val2));
        }

        //creating the Hamming_Distance method
        static string Hamming_Distance(string val1, string val2)
        {
            //creating integer constant variable
            int stringDiff = 0;
            //Creating variable to obtain length of entered string
            int length = val1.Length;

            // Conditional Statement to check is string 1 is similar to string 2
            if(val1 != val2)
            {
                foreach(char x in val1)
                {
                    foreach(char y in val2)
                    {
                        if(x.Equals(y))
                        {
                            stringDiff++;
                            break;
                        }
                    }
                }
                int r = length - stringDiff;
                //returning result
                return r.ToString();
            }
            else
            {
                return "0";
            }
        }
    }
}