namespace Math
{
    //creating a class
class ToDays    
{
    //creating a variable 
    int var = 10;
    //creating a method to house the algorthm 
    static void Age_To_Days(int intVal)
    {
        return intVal * 365;
    }
    //creating the Main method
    static void Main(string[] args)
    {
      //calling the method
        Age_To_Days(var);
    }
}

}

