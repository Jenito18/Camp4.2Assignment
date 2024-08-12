using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFileHandlingQuestion4
{
    
    public class CvData
    {
        //fields to store values
        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }


        //constructor
        public CvData(string name, string location, string qualification, string experience)
        {
           this.Name = name;
            this.Location = location;
            this.Qualification = qualification;
            this.Experience = experience;
        }

        // Method 
        public string CVCreation()
        {
            return ($"Name: {Name}\n" )+
                   ($"Location: {Location}\n") +
                   ($"Qualification: {Qualification}\n") +
                  ( $"Experience: {Experience}\n");
        }
    }
}
