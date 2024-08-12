namespace ConsoleAppFileHandlingQuestion5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // getting file path from user

                Console.Write("Enter the full path of the file to copy: ");

                string sourceFilePath = Console.ReadLine();

                // Check if the source file exists

                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("Source file does not exist. Please check the path and try again.");
                    return;
                }

                // getting input where to copy to new path
                // getting input where to copy to new path
                Console.Write("Enter the destination path where the file should be copied: ");
                string destinationFilePath = Console.ReadLine();

                // Perform the file copy
                File.Copy(sourceFilePath, destinationFilePath, true); 

                Console.WriteLine($"File copied successfully to {destinationFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}