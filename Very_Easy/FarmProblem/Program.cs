namespace math
{
    //creating class
    class FarmProgram
    {
        //generating the Main method
        static void Main(string[] args)
        {
            //creating the input for Chickens
            Console.Write("Please enter the amount of chickens you have: ");
            string str_TotChicken = Console.ReadLine();

            //creating the input for cows
            Console.Write("Please enter the amount of cows you have: ");
            string str_TotCows = Console.ReadLine();

            //creating the input for Pigs
            Console.Write("Please enter the amount of pigs you have: ");
            string str_TotPigs = Console.ReadLine();

            if(int.TryParse(str_TotChicken,out int int_TotChicken) && int.TryParse(str_TotCows, out int int_TotCows)
                && int.TryParse(str_TotPigs, out int int_TotPigs))
            {
                Console.WriteLine(
                    "Total Animal Legs: " + Animals(int_TotChicken, int_TotCows, int_TotPigs)
                );
            }
        }

        //creating the method for the legs of the animals
        static int Animals(int Chicken_Total, int Cow_Total , int Pig_Total){
            //calculating the amount of legs for a chicken
            int total_Chicken_Legs = Chicken_Total * 2;

            //calculating the amount of legs for a cows
            int total_Cow_Legs = Cow_Total * 4;

            //calculating the amount of legs for a Pigs
            int total_Pigs_Legs = Pig_Total * 4;

            //calculating total animal legs
            int TotAnimalLegs = total_Chicken_Legs + total_Cow_Legs + total_Pigs_Legs;

            //returning the total animal legs
            return TotAnimalLegs;

        }
    }
}