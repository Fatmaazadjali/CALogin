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
<<<<<<< HEAD
    public class EmployeeRebosatory<T> : GenaricReposatory<Employee> , IEmployee
=======
    public class EmployeeRebosatory : GenaricReposatory<Employee>, IEmployee
>>>>>>> 2cec68abd8d6a0ddab75894e94016e51f52cf2f9
    {
        

<<<<<<< HEAD
        public EmployeeRebosatory(ApplicationDbContext context) :base(context) { }

       

=======
        public EmployeeRebosatory(ApplicationDbContext context) : base (context)
        {
            _context = context;
        }
        public IEnumerable<Employee> address(string name)
        {
            var employees = _context.employees.Where(e => e.Name == name);
            return employees;
        }
>>>>>>> 2cec68abd8d6a0ddab75894e94016e51f52cf2f9

    }
}
