using Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace factura.Controllers
{
    public class FacturaController : Controller
    {
        private readonly FacturaService _service;

        public FacturaController(FacturaService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var facturas = _service.ObtenerTodos();
            return View(facturas);
        }

        public IActionResult Details(int id)
        {
            var factura = _service.ObtenerPorId(id);
            if (factura == null) return NotFound();
            return View(factura);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _service.Agregar(factura);
                return RedirectToAction("Index");
            }
            return View(factura);
        }

        public IActionResult Edit(int id)
        {
            var factura = _service.ObtenerPorId(id);
            if (factura == null) return NotFound();
            return View(factura);
        }

        [HttpPost]
        public IActionResult Edit(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _service.Actualizar(factura);
                return RedirectToAction("Index");
            }
            return View(factura);
        }

        public IActionResult Delete(int id)
        {
            var factura = _service.ObtenerPorId(id);
            if (factura == null) 
                return NotFound();
            return View(factura);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}

