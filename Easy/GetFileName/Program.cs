//creating namespace for file path
namespace File
{
    //creating class for File path
    class GetFileName
    {
        //creating Main method
        static void Main(string[] args)
        {
            //creating input variable and input message to be displayed
            Console.Write("Please enter file path: ");
            string str_FilePath = Console.ReadLine();

            //Conditional statement to check where users path contains '/'
            if(!str_FilePath.Contains('/'))
            {
                Console.Write("File name: " + str_FilePath);
            }
            else
            {
                Console.WriteLine(Get_FileName(str_FilePath));
            }

        }

        //Fabricating the Get_FileName Method
        static string Get_FileName(string filePath)
        {
            //creating array to store FilePath Csv items
            string[] FilePathCsv = filePath.Split('/');
            //fabricating variable for length of the array
            int length = FilePathCsv.Length;

            //returning result 
            return "File name: " + FilePathCsv[length-1];
        }
    }
}