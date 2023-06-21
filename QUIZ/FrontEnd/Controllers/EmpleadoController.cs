﻿using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoHelper empleadoHelper;

        // GET: EmpleadoController
        public ActionResult Index()
        {
            empleadoHelper = new EmpleadoHelper();
            List<EmpleadoViewModel> list = empleadoHelper.GetAll();

            return View(list);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            empleadoHelper = new EmpleadoHelper();
            EmpleadoViewModel empleado = empleadoHelper.GetByID(id);

            return View(empleado);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            empleadoHelper = new EmpleadoHelper();
            EmpleadoViewModel empleado = empleadoHelper.GetByID(id);

            return View(empleado);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoViewModel empleado)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
