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
[Route("Doctors")]
        public IActionResult Index()
        {
            var list = _dbContext.Doctors.ToList();
            return View(list);
        }

        public IActionResult DoneCreateD()
        {
            return View();
        }

        public IActionResult DoneEditD()
        {
            return View();
        }

        public IActionResult DoneDeleteD()
        {
            return View();
        }

        [HttpGet]
        [Route("Doctors/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Doctors/Create")]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    _dbContext.Doctors.Add(doctor);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneCreateD));
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

        [HttpGet]
       [Route("Doctors/Edit/{doctorid}")]
        public IActionResult Edit(int doctorid)
        {
            var doctor= _dbContext.Doctors.Find(doctorid);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        [HttpPost]
        [Route("Doctors/Edit/{doctorid}")]
        public IActionResult Edit(int doctorid,Doctor doctor)
        {
            if (ModelState.IsValid == true)
            {

                try
                {
                    _dbContext.Doctors.Update(doctor);
                    _dbContext.SaveChanges();
                    return RedirectToAction("DoneCreateD");

                }
                catch (Exception e)
                {
                    
                    ModelState.AddModelError("", e.Message);
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();
            }
            
        }
//ToDo: Make Methods
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