using ConsoleAppFileHandlingQuestion4;

namespace ConsoleAppFileHandlingQuestion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list

            List<CvData> Values = new List<CvData>();

           
            //getting input from user

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Location: ");
                string location = Console.ReadLine();

                Console.Write("Enter Qualification: ");
                string qualification = Console.ReadLine();

                Console.Write("Enter Experience: ");
                string experience = Console.ReadLine();

                // Adding data to the list

                Values.Add(new CvData(name, location, qualification, experience));
            

            // creating file path

            string folderPath = "CVs";
            Directory.CreateDirectory(folderPath);

            // Generate a CV file for each entity
            foreach (var Value in Values)
            {
                string fileName = $"{Value.Name}_{Value.Location}.txt";

                string filePath = Path.Combine(folderPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(Value.CVCreation());
                }

                Console.WriteLine($"CV for {Value.Name} generated: {filePath}");
            }

            Console.WriteLine("\nAll CVs have been generated successfully.");
        }
    }
}
