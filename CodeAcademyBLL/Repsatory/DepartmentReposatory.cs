using System;
using System.Collections.Generic;
using System.Linq;
using CodeAcademyDAL.Context;
using System;
using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Model;
using System.Threading.Tasks;
using CodeAcademyDAL.Context;


namespace CodeAcademyBLL.Repsatory
{
    public class DepartmentReposatory : GenaricReposatory<Department>, IDepartment
    {


        public DepartmentReposatory(ApplicationDbContext context) : base(context) { }




    }
}
