using Datos.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPrueba.Controllers
{
    public class TipoVehiculoController : Controller
    {
        private readonly EjercicioEvaluacionContext _context;
        public TipoVehiculoController(EjercicioEvaluacionContext context)
        {
            _context = context;

        }
        // GET: TipoVehiculoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoVehiculoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoVehiculoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoVehiculoController/Create
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

        // GET: TipoVehiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoVehiculoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: TipoVehiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoVehiculoController/Delete/5
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
