using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Index() { return View(); }

       [Route("/Form")]
      public ActionResult Form() { return View(); }

      [Route("/SecondForm")]
      public ActionResult SecondForm() { return View(); }

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
[Route("/secondMadLib")]
public ActionResult SecondMadLib(string dogName, string activity, string adjective, string food)
{
  SecondMadLib mySecondMadLib = new SecondMadLib();
  mySecondMadLib.SetDog(dogName);
  mySecondMadLib.SetActivity(activity);
  mySecondMadLib.SetAdjective(adjective);
  mySecondMadLib.SetFood(food);
  return View(mySecondMadLib);
}
    
    
    }
  }
