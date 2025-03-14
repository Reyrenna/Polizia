using Microsoft.AspNetCore.Mvc;
using Polizia.Services;
using Polizia.ViewModels;
using Polizia.Models;

namespace Polizia.Controllers;

public class TipoViolazioneController : Controller
{
    private readonly TipoViolazioneService _tipoViolazioneService;

    public TipoViolazioneController(TipoViolazioneService tipoViolazioneService)
    {
        _tipoViolazioneService = tipoViolazioneService;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _tipoViolazioneService.GetViolazione());
    }

    [Route("AddTipoViolazione")]
    public async Task<IActionResult> Add()
    {
        return View();
    }

    [HttpPost("AddTipoViolazione")]
    public async Task<IActionResult> Add(AddTipoViolazioneViewModel addTipoViolazioneViewModel)
    {
        if (ModelState.IsValid)
        {
            await _tipoViolazioneService.AddTipoViolazione(addTipoViolazioneViewModel);
            return RedirectToAction("Index");
        }
        return View(addTipoViolazioneViewModel);
    }

    [Route("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _tipoViolazioneService.DeleteViolazione(id);
        return RedirectToAction("Index");
    }
}
