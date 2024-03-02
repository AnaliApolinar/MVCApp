using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MVCApp.Controllers
{
	public class HelloWorldController : Controller
	{
		public IActionResult index()
		{
			return View();
		}

		public IActionResult Welcome(string name,int numTimes=1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}

		//public string index()
		//{
		//    return "this is my default action...";


		//}

		//Get: /HelloWorld/Welcome/
		//Requieres using System.Text.Encodings.Web;
		//Get: /HelloWorld/Welcome?name=analizeth&numTimes=5/

		//public string Welcome(string name, int numTimes=1)
		//{
		//    //return "This is the welcome action method...";
		//    return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is:{numTimes}");
		//}
	}

}
