<<<<<<< HEAD
﻿
=======
﻿using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Model;
>>>>>>> 2cec68abd8d6a0ddab75894e94016e51f52cf2f9
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartment _department;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _department.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dep)
        {
            
            _department.Create(dep);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _department.Get(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Department emp)
        {
            if (ModelState.IsValid)
            {
                _department.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _department.Get(id);
            _department.Delete(emp);
            return RedirectToAction("Index");
        }

    }
}
