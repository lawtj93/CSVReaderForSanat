using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class EmployeeManagerFactory 
    {
        public IEmployeeInterface GetEmployeeInterface(CSVData data)
        {
            IEmployeeInterface returnvalue = null;

            if (data.EType.Contains("FullTime"))
            {
                returnvalue = new FullTimeEmployee(data);
            }
            else if (data.EType.Contains("Contract"))
            {
                returnvalue = new ContractEmployee(data);
            }
            return returnvalue;
        }
    }

    public class FullTimeEmployee : Employee, IFulltimeEmployeeInterface
    {
        private CSVData data { get; set; }
        public string Salary { get; set; }

        public FullTimeEmployee(CSVData _data)
        {
            data = _data;
        }
        public void AddEmployeeDetails()
        {
            Name = data.EName;
            Gender = data.EGender;
            EmploymentType = data.EType;
            AddFullTimeDetails();
        }

        public void AddFullTimeDetails()
        {
            Salary = data.ESalary;
        }
    }

    public class ContractEmployee : Employee, IContractEmployeeInterface
    {
        private CSVData data { get; set; }
        public string Rate { get; set; }

        public ContractEmployee(CSVData _data)
        {
            data = _data;
        }
        public void AddEmployeeDetails()
        {
            Name = data.EName;
            Gender = data.EGender;
            EmploymentType = data.EType;
            AddContractDetails();
        }

        public void AddContractDetails()
        {
            Rate = data.ERate;
        }
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EmploymentType { get; set; }
    }
}
