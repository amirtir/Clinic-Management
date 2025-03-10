﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dashbord.Data;
using Microsoft.AspNetCore.Mvc;
using dashbord.Models;
using dashbord.Migrations;
using dashbord.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dashbord.Controllers
{
    public class ClinicsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        

        public ClinicsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
   
        }
        // GET: /<controller>/

        public IActionResult DoneCreate()
        {
            return View();
        }

        public IActionResult DoneEdit()
        {
            return View();
        }
        
        public IActionResult DoneDelete()
        {
            return View();
        }
[Route("Clinics")]
        public IActionResult Index()
        {
            var clinicList = _dbContext.Clinics.ToList();
            return View(clinicList);
        }

        [HttpGet]
        [Route("Clinics/Create")]
        public IActionResult Create()
        {
            var doctorlist = _dbContext.Doctors.ToList();

            var model = new DoctorViewModel();
            model.DoctorsListItems = new List<SelectListItem>();

            foreach (var item in doctorlist)
            {
                model.DoctorsListItems.Add(new SelectListItem
                {
                    Text = item.LastName,
                    Value = item.doctorId.ToString()
                });
            }

            ViewBag.model = model;


          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Clinics/Create")]
        public IActionResult Create(Clinic cln)
        {
            try
            {
                _dbContext.Clinics.Add(cln);
                _dbContext.SaveChanges();
                 return RedirectToAction(nameof(DoneCreate));
            }
            catch
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();
            }
            //if (ModelState.IsValid)
            //{
            //    _dbContext.Clinics.Add(cln);
            //    _dbContext.SaveChanges();
            //}
            //else {
            //    ModelState.AddModelError("", "You have to fill all the required fields ");
            //}
            ////return View();
            //return RedirectToAction(nameof(DoneCreate));



        }
[Route("Clinics/Edit/{id}")]
        public IActionResult Edit(int Id)
        {
            var item = _dbContext.Clinics.Find(Id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
[Route("clinics/Edit/{id}")]
        public IActionResult Edit(int Id, Clinic cl2)
        {
            try
            {
                //string fileName = UploadFile(cl2.File, viewModel.ImageUrl);

                if (Id != cl2.ClinicId ) { return NotFound(); }
                else
                {
                    _dbContext.Clinics.Update(cl2);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneEdit));
                }
            }
            catch
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();

            }
            //if (Id != cl2.Id)
            //{
            //    return NotFound();
            //}
            //if (ModelState.IsValid)
            //{
            //    _dbContext.Update(cl2);
            //    _dbContext.SaveChanges();
            //}
            ////return View(cl2, );
            //return RedirectToAction(nameof(DoneEdit));



        }

        [HttpGet]
       [Route("Clinics/Delete/{id}")]
        public IActionResult Delete(int Id)
        {
            var clin_item = _dbContext.Clinics.Find(Id);
            if (clin_item == null)
            {
                return NotFound();
            }
            return View(clin_item);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("clinics/Delete/{id}")]
        public IActionResult Delete(int Id, Clinic dclin)
        {
            dclin = _dbContext.Clinics.Find(Id);
            try
            {
                if (dclin == null) { return NotFound(); }
                else
                {
                    _dbContext.Clinics.Remove(dclin);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneDelete));
                }
            }
            catch
            {
                return View();

            }
            //if (dclin == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    _dbContext.Clinics.Remove(dclin);
            //    _dbContext.SaveChanges();
            //}
            //return RedirectToAction(nameof(DoneDelet));



        }





    }
}

