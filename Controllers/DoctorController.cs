using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dashbord.Data;
using dashbord.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dashbord.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public DoctorController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = _dbContext.Doctors.ToList();
            return View(list);
        }

        public IActionResult DoneCreatD()
        {
            return View();
        }

        public IActionResult DoneEditD()
        {
            return View();
        }

        public IActionResult DoneDeletD()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid == true)
            {

                try
                {
                    _dbContext.Doctors.Add(doctor);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneCreatD));
                }
                catch 
                {
                    ModelState.AddModelError("", "You have to fill all the required fields ");
                    return View();
                }
             
            }
            else
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();
            }
         
        }
        public IActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public IActionResult MyPatients()
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}

