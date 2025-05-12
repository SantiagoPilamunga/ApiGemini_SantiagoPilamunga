using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApiGemini_Jorge_Ramos.Models;
using ApiGemini_Jorge_Ramos.Repositories;
using ApiGemini_Jorge_Ramos.Interfaces;

namespace ApiGemini_Jorge_Ramos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IChatBotService _chatBotService;

    public HomeController(ILogger<HomeController> logger, IChatBotService chatBotService)
    {
        _logger = logger;
        _chatBotService = chatBotService;
    }

    public async Task <IActionResult> Index()
    {
        
        string answer = await _chatBotService.GetChatbotResponse("Dame un resumen de la pelicula titanic");
        return View(answer);
    }

    public IActionResult Privacy()
    {

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
