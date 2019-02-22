using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

  //   [HttpPost("/wordcounter")]
  //   public ActionResult Create(string sentence, string word)
  //   {
  //     RepeatCounter newSentenceWord = new RepeatCounter();
  //     return RedirectToAction("Index");
  //   }
  }
}
