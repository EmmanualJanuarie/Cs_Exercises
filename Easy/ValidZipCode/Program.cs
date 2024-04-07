//creating namespace for ValidZipCode
namespace String
{
    //creating class for ValidZipCode
    class ValidZipCode
    {
        //creating the Main method
        static void Main(string[] args)
        {
            //Creating the input variable and input message
            Console.Write("Please enter zip code: ");
            string str_ZipCode = Console.ReadLine();

            //calling the method
            Console.Write(IsValidZipCode(str_ZipCode));
        }

        //creating the method for ValidZip code detector
        static string IsValidZipCode(string ZipCode)
        {
            //creating ctemp variable
            string result = " ";
            //creating length variable
            int length = ZipCode.Length;
            foreach (char x in ZipCode)
            {
                if(!char.IsDigit(x))
                {
                    result += "False";
                    break;
                }
                else if(length > 5)
                {
                     result += "False";
                     break;
                }
                 else if(ZipCode.Contains(' '))
                {
                     result += "False";
                     break;
                }
                else
                {
                    result += "True";
                    break;
                }
            }
            return result;
        }
    }
}