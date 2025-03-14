using Microsoft.AspNetCore.Mvc;
using Polizia.Services;
using Polizia.ViewModels;
using Polizia.Models;

namespace Polizia.Controllers;

public class VerbaleController : Controller
{

    private readonly VerbaleService _verbaleService;
    public VerbaleController(VerbaleService verbaleService)
    {
        _verbaleService = verbaleService;
    }
    public async Task<IActionResult> Index()
    {
        
        return View(await _verbaleService.GetVerbale());
    }
    [Route("AddVerbale")]
    public async Task<IActionResult> Add()
    {
        return View();
    }
    [HttpPost("AddVerbale")]
    public async Task<IActionResult> Add(AddVerbaleViewModel addVerbaleViewModel)
    {
        if (ModelState.IsValid)
        {
            await _verbaleService.AddVerbale(addVerbaleViewModel);
            return RedirectToAction("Index");
        }
        return View(addVerbaleViewModel);
    }
    [Route("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _verbaleService.DeleteVerbale(id);
        return RedirectToAction("Index");
    }
}
