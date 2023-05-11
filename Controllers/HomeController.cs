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
        ViewBag.Equipos1 = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.Equipos = Equipos.ListaEquipos;
        ViewBag.Remeras = Equipos.ListaRemeras;
        ViewBag.Pantalones = Equipos.ListaPantalones;
        ViewBag.Medias = Equipos.ListaMedias;
        return View();
    }
    public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalones, int Remera)
    {
        Indumentaria indumentaria = new Indumentaria(Equipos.ListaRemeras[Remera],Equipos.ListaPantalones[Pantalones],Equipos.ListaMedias[Media]);
        Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo],indumentaria);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
