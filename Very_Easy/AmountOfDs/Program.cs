using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace lang_Fundamentals
{
    class FindDs
    {
          static string IsChar(string strVal)
        {
            //empty variable
            int DAmount = 0;//creating a empy variable to store the amount of D's in a text
            if (strVal.Contains('d') || strVal.Contains('D'))//CHECKS TO SEE IS THE VARIABLE CONTAINS D'S
            {
                
              foreach(char x in strVal)//IF TRUE THEN IT CHECKS HOW MANY D'S Are prsent
              {
                
                if(x.Equals('d')|| x.Equals('D'))//while iterating if the index is a 'D', it adds 1
                {
                    DAmount++;//increments by 1 if index equals char d
                }  
              }
              Console.WriteLine("Amount of D's is: " + DAmount); 
            }else
            {
                Console.WriteLine("The provided text does not contain the letter 'D'.");
            }
                return DAmount.ToString();//.tostring() is used to convert a int to a string

        }
        static void Main(string[] args)
        {
            string strVal1 = "My friend Dylan got distracted in school.";

            Console.WriteLine("Result:" + IsChar(strVal1));
           
        }

      
    }
}
