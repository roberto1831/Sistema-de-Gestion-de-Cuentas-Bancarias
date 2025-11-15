using Microsoft.AspNetCore.Mvc;
using BusinessAccessLayer;
using BusinessEntity;

namespace WebApplication1.Controllers
{
    public class CuentaController : Controller
    {
        private readonly Registro registro = new Registro();

        // GET: /Cuenta/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Cuenta/Crear
        [HttpPost]
        public IActionResult Crear(CuentaBancaria cuenta)
        {
            if (ModelState.IsValid)
            {
                int resultado = registro.Insertar(cuenta);
                if (resultado == 1)
                {
                    ViewBag.Mensaje = "Cuenta registrada con éxito.";
                }
                else if (resultado == -1)
                {
                    ViewBag.Mensaje = "La cuenta ya existe.";
                }
                else
                {
                    ViewBag.Mensaje = "Error al registrar la cuenta.";
                }
            }
            return View();
        }

        // GET: /Cuenta/Buscar
        public IActionResult Buscar()
        {
            return View();
        }

        // POST: /Cuenta/Buscar
        [HttpPost]
        public IActionResult Buscar(string numeroCuenta)
        {
            var cuenta = registro.Buscar(numeroCuenta);

            if (cuenta != null)
            {
                ViewBag.Resultado = cuenta;
            }
            else
            {
                ViewBag.Mensaje = "Cuenta no encontrada.";
            }

            return View();
        }

        // GET: /Cuenta/List
        public IActionResult List()
        {
            var cuentas = registro.ObtenerTodas();
            return View(cuentas);
        }

        
        public IActionResult Editar(string numeroCuenta)
        {
            var cuenta = registro.Buscar(numeroCuenta);
            if (cuenta == null)
                return NotFound();

            return View(cuenta);
        }

        
        [HttpPost]
        public IActionResult Editar(CuentaBancaria cuenta)
        {
            if (ModelState.IsValid)
            {
                int result = registro.Actualizar(cuenta);
                if (result == 1)
                    return RedirectToAction("List");

                ViewBag.Mensaje = "Error al actualizar la cuenta.";
            }

            return View(cuenta);
        }
        
        public IActionResult Eliminar(string numeroCuenta)
        {
            if (string.IsNullOrEmpty(numeroCuenta))
                return BadRequest();

            int resultado = registro.Eliminar(numeroCuenta);

            if (resultado == 1)
                TempData["Mensaje"] = "Cuenta eliminada correctamente.";
            else
                TempData["Mensaje"] = "Error al eliminar la cuenta.";

            return RedirectToAction("List");
        }
    }
}
