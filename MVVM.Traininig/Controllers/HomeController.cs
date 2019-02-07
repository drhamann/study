using MVVM.Training.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVM.Traininig.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TraininProductViewModel trainingManager = new TraininProductViewModel();
            trainingManager.HandleRequest();
            return View(trainingManager);
        }

        [HttpPost]
        public ActionResult Index(TraininProductViewModel viewModel)
        {
            viewModel.IsValid = ModelState.IsValid;
            viewModel.HandleRequest();
            if(viewModel.IsValid)
                ModelState.Clear();

            return View(viewModel);
        }
    }
}