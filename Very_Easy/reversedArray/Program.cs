using System;
//Creating namespace for reversed array program
namespace ReversedArray
{
    //creating the class for the reverse array
    class ArrayRevered
    {
        //creating the Main method
        static void Main(string[] args)
        {
            //creating the array
            int[] myArray = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

            //printing text to the terminal
            Console.Write("Ascending order: ");
            //generate a for loop to iterate through  array
            for(int i= 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
             Console.Write();

            //calling the method 
            ReverseItems(myArray, 0, (myArray.Length - 1));

        }

        //creating the reverse array method
        public static void ReverseItems(int[] arr, int FirstItem, int LastItem)
        {
            //creating a while loop
            while(FirstItem < LastItem)
            { 
                //creating a temp variable, that accepts the FirstItem
                int var_temp = arr[FirstItem];//contains index zero's value

                //assigning lastIndex item to the emptied first index
                arr[FirstItem] = arr[LastItem];//contains index of last item 

                //assing the temp variable value to the emptied last index
                arr[LastItem] = var_temp;//cotains temporary variables value]

                //incrementing the first item
                FirstItem++;
                //decrement the last item
                LastItem--;
            }
            //printing text to the terminal
            Console.Write("Descending order: ");

            //creating a for loop  to loop through the parametered array
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}