namespace Math
{
    //creating a class
class ToDays    
{
    //creating a method to house the algorthm 
    static int Age_To_Days(int intVal)
    {
        return intVal * 365;
    }
    //creating the Main method
    static void Main(string[] args)
    {
        //creating a variable 
        Console.WriteLine("Please enter your Age: ");
        String user_Age = Console.ReadLine();

        //initializing tryparse
        if (int.TryParse(user_Age, out int intUser_Age ))
        {
            //calling the method
            Console.WriteLine("You are " +  Age_To_Days(intUser_Age)+ " " + "Days old.");
        }else
        {
            Console.WriteLine("Entry Must be a number!");
        }
    
      
       
    }
}

}

