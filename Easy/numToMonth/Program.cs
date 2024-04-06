//Namespace for dates
namespace Dates
{

    //creating enum for months
    enum Months
    {
        January=1, February, March,
        April, May, June,
        July, August, September,
        October, November, December
    }
    //creating class
    class ToMonth
    {
        //Main Method
        static void Main(string[] args)
        {
            //input message
            Console.Write("Please enter corresponding number to month [1-12]: ");
            string str_Month = Console.ReadLine();

            // Converting string to int
            if(int.TryParse(str_Month, out int int_Month))
            {
                //creating instance of Months
                Months month = (Months)Enum.ToObject(typeof(Months), int_Month);
                //Displaying result in terminal
                Console.WriteLine(month);

                //validation
                if(int_Month == 0)
                {
                    Console.WriteLine("Can't enter zero!. Please enter a number '1' to '12'");
                }
            }
        }
    }
}