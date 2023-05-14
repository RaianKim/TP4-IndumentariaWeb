using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Equipos = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        return View();
    }
    public IActionResult GuardarIndumentaria (int Equipo, int Camiseta, int Pantalon, int Media)
    {
        int aux = Equipo;
        int aux2 = Camiseta;
        int aux3 = Pantalon;
        int aux4 = Media;
        Indumentaria indumentaria = new Indumentaria(Equipos.ListaRemeras[aux2],Equipos.ListaPantalones[aux3],Equipos.ListaMedias[aux4]);
        ViewBag.Indu = Equipos.IngresarIndumentaria(Equipos.ListaEquipos[aux],indumentaria);
        ViewBag.Equipos = Equipos.EquiposIndumentaria;
        return View("index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
