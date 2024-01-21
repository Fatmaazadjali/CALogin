using CodeAcademyDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Interfaces
{
    public interface IEmployee : IGeneric<Employee>
    {
      //  IEnumerable<Employee> address(string name);// address if we want to add more functions for employee only (features)
    }
}
