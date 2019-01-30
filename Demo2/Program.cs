using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: As time is limited as I have some other things I need to do tonight, I have
            // chosen to skip a few things as the design pattern concepts is the goal of the project
            // Validation, Exception Handling and Logging are not included. If you wish to see this
            // implemented I can work on it tomorrow
            // Current code works for the csv file included in the project SampleEmployees2.csv
            // SampleEmployees1.csv also included to test performance as I've added 5000+ rows
            // There is flaws in parts of the design however the small time constraint put me in a position
            // Where I needed to rush

            //Create list of company objects so each company has its own object
            List<Company> Company = new List<Company>();
            
            //Pass the file location to LINQ statement below
            List<CSVData> values = File.ReadAllLines(@"C:\Users\Joseph\source\repos\Demo\Demo2\SampleEmployees2.csv")
                                            .Skip(1)
                                            .Select(v => CSVData.FromCsv(v))
                                            .OrderBy(x => x.CName)
                                            .ToList();

            //Below code to retrieve a list of unique company names
            var unique_items = new HashSet<CSVData>(values);
            List<string> companies = unique_items.Select(x => x.CName).Distinct().ToList();

            //foreach statement to create company object for each company, and commence the adding of employees
            foreach (var company in companies)
            {
                var temp = values.Where(x => x.CName == company).ToList();
                Company c = new Company(temp);
                Company.Add(c);
            }

            int i = 0;
            // No time for client interface so I verified it working by debugging and inspecting Company object
        }
    }    
}
