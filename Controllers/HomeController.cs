using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NotasApp.Models;

namespace NotasApp.Controllers;

public class HomeController : Controller
{
    private RegistroNota _context;
    public HomeController(RegistroNota c)
    {
        _context = c;
    }

    public IActionResult Index ()
    {
        var notas = _context.Notas.ToList(); // Imprime cada registro hecho en forma de lista
        return View(notas);
    }

    public IActionResult Registro()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registro(Alumno n)
    {
        if(ModelState.IsValid)
        {
            n.CalcularPromedio();
            _context.Add(n);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        else
        {
            return View(n);
        }
    }
}
