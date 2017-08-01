using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;
using System;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/parcel/list")]
    public ActionResult ViewAll()
    {
      List<ParcelObject> allParcels = ParcelObject.GetAll();
      return View(allParcels);
    }

    [HttpPost("/parcel/create")]
    public ActionResult CreateParcel()
    {
      ParcelObject myParcelVariable = new ParcelObject();
      myParcelVariable.SetWidth(int.Parse(Request.Form["new-width"]));
      myParcelVariable.SetLength(int.Parse(Request.Form["new-length"]));
      myParcelVariable.SetHeight(int.Parse(Request.Form["new-height"]));
      myParcelVariable.SetWeight(int.Parse(Request.Form["new-weight"]));
      myParcelVariable.Save();

      return View(myParcelVariable);
    }
  }
}
