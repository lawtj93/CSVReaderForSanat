using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Company : CompanyDetails
    {
        public Company(List<CSVData> items)
        {
            Name = items.First().CName;
            Address = items.First().CAddress;

            List<IEmployeeInterface> list = new List<IEmployeeInterface>();

            foreach (CSVData item in items)
            {
                EmployeeManagerFactory emp = new EmployeeManagerFactory();
                IEmployeeInterface empManager = emp.GetEmployeeInterface(item);
                empManager.AddEmployeeDetails();
                list.Add(empManager);
            }

            Employee = list;
        }
    }

    public abstract class CompanyDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<IEmployeeInterface> Employee { get; set; }
    }
}
