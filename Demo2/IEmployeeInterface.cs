using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public interface IEmployeeInterface
    {
        void AddEmployeeDetails();
    }

    public interface IFulltimeEmployeeInterface : IEmployeeInterface
    {
        void AddFullTimeDetails();
    }

    public interface IContractEmployeeInterface : IEmployeeInterface
    {
        void AddContractDetails();
    }
}
