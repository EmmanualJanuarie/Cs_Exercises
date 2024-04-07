//creating class for circle and using as a constructor
class Circle(double r)
{
    //creating public variable for Area of Circle 
    public double getArea = Math.PI * (r * 2);

     //creating public variable for Perimeter of Circle 
    public double getPer = 2 * (Math.PI * r);

    //creating Main Method
    static void Main(string[] args)
    {
        //creating input variable assigned as string
        Console.Write("Please enter radius: ");
        string str_Radius = Console.ReadLine();

        //converting string to double
        if(double.TryParse(str_Radius, out double db_Radius))
        {
            //creating instance of Circle Constructor
            Circle circy  = new(db_Radius);

            //Displaying result into Terminal
            Console.WriteLine("Area_Circle: " + circy.getArea);
            Console.WriteLine("Perimeter_Circle: " + circy.getPer);
        }

    }

    
}