using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Context;
using CodeAcademyDAL.Model;
using System;
using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Repsatory
{

    public class EmployeeRebosatory<T> : GenaricReposatory<Employee>, IEmployee
    {
        private readonly ApplicationDbContext _context;
      


            public EmployeeRebosatory(ApplicationDbContext context) : base(context)
            {
                _context = context;
            }
            public IEnumerable<Employee> address(string name)
            {
                var employees = _context.employees.Where(e => e.Name == name);
                return employees;
            }


        }
    
}
