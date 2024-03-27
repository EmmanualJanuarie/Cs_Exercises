namespace arrays
{
    //creating a class 
    class First_Last
    { 
        //creating the method for first and last items in array
        static void First_Last_array(int firstItem , int lastItem)
        {
            Console.WriteLine($"Returned: [{firstItem},{lastItem}]");
        }
        static void Main(string[] args)
        {
           int[] myArray = {10, 20, 30, 40 , 50 , 60, 70 , 80, 90, 100};
            // creating a vartiable for the first item in the array
            int item_First = myArray[0];
            // creating a vartiable for the last item in the array
            int item_Last = myArray[myArray.Length -1];

            //calling the First_Last method
          First_Last_array(item_First, item_Last);
        }
    }
} 