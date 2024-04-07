//creating namespace for palidrome program
namespace String
{
    //creating class for Palidrome Program
    class Palidrome
    {
        //creating Main method
        static void Main(string[] args)
        {
            //creating input variable assigned as string
            Console.Write("Is yoour word a Palidrome? Please enter a word: ");
            string str_Palidrome = Console.ReadLine();

            //calling method
           Console.WriteLine( IsPalidrome(str_Palidrome));

        }

        //creating Palidrom 
        static string IsPalidrome(string word)
        {
            //creating a constant variable
            string result = " ";
            //conveting string to an array of chars
            char[] chars = word.ToCharArray();
            //reversing the chars array
            Array.Reverse(chars);

            //storing chars array as a new string variable
            string Pal_Word = new(chars);

            //conditional statement to check if entered word is a palidrome
            if(word != Pal_Word)
            {
                result = "False";
            }
            else
            {
                result = "True";
            }

            //returning result
            return result;
        }
    }
}