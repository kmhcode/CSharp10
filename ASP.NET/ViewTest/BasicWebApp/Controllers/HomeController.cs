namespace BasicWebApp.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
	private readonly ICounterService _counter;

	public HomeController(ICounterService counter) => _counter = counter;

	public IActionResult Index(string id)
	{
		if(id != null && (_counter.CountNext(id) % 2) == 0)
			return View("~/Views/Hello.cshtml");
		return View();
	}
}

