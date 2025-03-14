using Microsoft.AspNetCore.Mvc;
using Polizia.Services;
using Polizia.ViewModels;
using Polizia.Models;

namespace Polizia.Controllers;

[Route("/Anagrafica")]

public class AnagraficaController : Controller
{
    private readonly AnagraficaService _anagraficaService;
    public AnagraficaController(AnagraficaService anagrafeService)
    {
        _anagraficaService = anagrafeService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _anagraficaService.GetAnagrafiche());
    }

    [Route("AddAnagrafica")]
    public async Task<IActionResult> Add()
    {
        return View();
    }

    [HttpPost("AddAnagrafica")]
    public async Task<IActionResult> Add(AddAnagraficaViewModel addAnagraficaViewModel)
    {
        if (ModelState.IsValid)
        {
            await _anagraficaService.AddAnagrafica(addAnagraficaViewModel);
            return RedirectToAction("Index");
        }
        return View(addAnagraficaViewModel);
    }

    [Route("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _anagraficaService.DeleteAnagrafica(id);
        return RedirectToAction("Index");
    }
}
