using Datos.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPrueba.Controllers
{
    public class VehiculoController : Controller
    {
        private readonly EjercicioEvaluacionContext _context;
        public VehiculoController(EjercicioEvaluacionContext context)
        {
            _context = context;
                
        }

        // GET: VehiculoController
        public ActionResult Index()
        {
            List<Vehiculo> lisvehiculo = _context.Vehiculos.ToList();

            return View(lisvehiculo);
        }

        // GET: VehiculoController/Details/5
        public ActionResult Details(String id)
        {
            Vehiculo vehiculo=_context.Vehiculos.Where(y=>y.Codigo==id).FirstOrDefault();

            return View(vehiculo);
        }

        // GET: VehiculoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Vehiculo.Estado=1
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculoController/Edit/5
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

        // GET: VehiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehiculoController/Delete/5
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
