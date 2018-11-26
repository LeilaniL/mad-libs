using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Form() { return View(); }

    [Route("/madlibs")]
public ActionResult MadLibs(string student, string station, string pair, string verb, string adjective, string secondAdjective)
{
  MadLib myMadLib = new MadLib();
  myMadLib.SetStudent(student);
  myMadLib.SetStation(station);
  myMadLib.SetPair(pair);
  myMadLib.SetVerb(verb);
  myMadLib.SetAdjective(adjective);
  myMadLib.SetSecondAdjective(secondAdjective);
  return View(myMadLib);
}
    
    
    }
  }
