using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Context;
using CodeAcademyDAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Repsatory
{
    public class DepartmentRebosatory : GenaricReposatory<Department>, IDepartment
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRebosatory(ApplicationDbContext context) : base (context) {

           
        }

        public IEnumerable<Department> address(string name)
        {
            var Departments = _context.Departments.Where(x => x.Name == name);
            return Departments;
        }
    }
}
