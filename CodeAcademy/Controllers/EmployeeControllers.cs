using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class EmployeeControllers : Controller
    {
        private readonly IEmployee _Employee;

        public EmployeeControllers(IEmployee employeerepo) {
            _Employee = employeerepo;
                }

        
        public IActionResult Index()  =>   View();

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _Employee.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            //if(dep == null)
            //{
            //    return BadRequest();
            //}
            _Employee.Create(emp);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _Employee.Get(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _Employee.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _Employee.Get(id);
            _Employee.Delete(emp);
            return RedirectToAction("Index");
        }


    }
}
