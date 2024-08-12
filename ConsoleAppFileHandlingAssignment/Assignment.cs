using System.Diagnostics.Tracing;

namespace ConsoleAppFileHandlingAssignment
{
    internal class Assignment
    {
       
        static void Main(string[] args)
        {

            #region Question1
            /* 
             try
             {
                 //creating text file


                 string filePath = "word.txt";

                 //creating and writing file

                 using (FileStream fsw = new FileStream(filePath, FileMode.Append, FileAccess.Write)) 
                 using (StreamWriter sw = new StreamWriter(fsw))
                 {

                     //to write text in  the file
                     sw.WriteLine("Hi I am Jose Jenito");
                 }

                 //to print the output in console
                 Console.WriteLine("file written");






             }
             catch (Exception ex) 
             {
                 Console.WriteLine(ex.Message);


             }

 */


            #endregion


            #region Question 2
            /*
            try
            {
                //file path
                string filePath = "data.txt";

                //check the file exist or not
                if (File.Exists(filePath))
                {
                    //read all content

                    string content = File.ReadAllText(filePath);

                    char[] result = content.ToCharArray();


                    //using for loop to iterate fromm position 2 to 7
                    if (result != null)
                    {
                        for (int i = 2; i < 7; i++)
                        {
                            Console.Write(result[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Character Not found");
                    }
                }

            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
*/

            #endregion







            #region Question5
            /*
            Console.WriteLine("Enter the source file path:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Enter the destination file path:");
            string destinationFilePath = Console.ReadLine();

            File.Copy(filePath, destinationFilePath, true);

            Console.WriteLine($"File has been copied from {filePath} to {destinationFilePath}.");

            */
            #endregion

            Console.ReadKey();
        }
    }
}
