using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/form")]
    public ActionResult Form() 
    { 
      return View(); 
    }
    
    // [Route("/")]
    // public ActionResult Index() 
    // { 
    //   return View(); 
    // }



    [Route("/story2")]
    public ActionResult Index(string adj1, string adj2, string noun1, string noun2, string pluralNoun1, string game1, string pluralNoun2, string verbIng1, string verbIng2, string pluralNoun3, string verbIng3, string noun3, string plant1, string body1, string place1, string verbIng4, string adj3, string number, string pluralNoun4)
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.Adj1 = adj1;
      myMadLibs.Adj2 = adj2;
      myMadLibs.Noun1 = noun1;
      myMadLibs.Noun2 = noun2;
      myMadLibs.PluralNoun1 = pluralNoun1;
      myMadLibs.Game1 = game1;
      myMadLibs.PluralNoun2 = pluralNoun2;
      myMadLibs.VerbIng1 = verbIng1;
      myMadLibs.VerbIng2 = verbIng2;
      myMadLibs.PluralNoun3 = pluralNoun3;
      myMadLibs.VerbIng3 = verbIng3;
      myMadLibs.Noun3 = noun3;
      myMadLibs.Plant1 = plant1;
      myMadLibs.Body1 = body1;
      myMadLibs.Place1 = place1;
      myMadLibs.VerbIng4 = verbIng4;
      myMadLibs.Adj3 = adj3;
      myMadLibs.Number = number;
      myMadLibs.PluralNoun4 = pluralNoun4;
      return View(myMadLibs);
    }
  }
}
