//creating namespace
namespace String
{
    //creating the class for letters only program
    class LettersOnly
    {
        //fabricating the Main Method
        static void Main(string[] args)
        {
            //creating input variable and display message
            Console.Write("Please enter a string: ");
            string str_Entry = Console.ReadLine();

            //calling the method
            Console.WriteLine(Letters_Only(str_Entry));


        }

        //creating the Letters_Only Method
        static string Letters_Only(string uentry)
        {
            //creating a flag vcariable
            string result = " ";
            //creating foreach loop fot methods parameter
            foreach(char x in uentry)
            {
                //conditional statement to check if charater is indeed a letter?
                if(char.IsLetter(x))
                {
                    //adding x char to result
                    result +=x;
                }
            }
             return result;
        }
    }
}