using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using teploob.Data;
using teploob.Models;
using TeploobLibrary1;

namespace teploob.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly MyApplicationContex _contex;

        public HomeController(ILogger<HomeController> logger, MyApplicationContex contex)
        {
            _logger = logger;
            _contex = contex;
        }

        public IActionResult Index()
        {

            var inputDatas = _contex.InputDatas.ToList();


            return View(inputDatas);
        }


        [HttpPost]
        public IActionResult TestPage(TeploobmenInputData inputData)
        {
            var lib = new TeploobmenLib();
            var result = lib.Calc(inputData);

            _contex.InputDatas.Add(new InputData
            {
                H = inputData.H,
                Tmaterial = inputData.Tmaterial,
                Tgaza = inputData.Tgaza,
                Vgaza = inputData.Vgaza,
                Cgaza = inputData.Cgaza,
                Rashod = inputData.Rashod,
                Gmaterial = inputData.Gmaterial,
                AV = inputData.AV,
                Dapparata = inputData.Dapparata,
                DateAdd = DateTime.Now,

            });

            _contex.SaveChanges();


            var model = new TestPageModel
            {
                InputData = new InputData
                {
                    H = inputData.H,
                    Tmaterial = inputData.Tmaterial,
                    Tgaza = inputData.Tgaza,
                    Vgaza = inputData.Vgaza,
                    Cgaza = inputData.Cgaza,
                    Rashod = inputData.Rashod,
                    Gmaterial = inputData.Gmaterial,
                    AV = inputData.AV,
                    Dapparata = inputData.Dapparata
                },
                OutputData = result
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult TestPage(int variant)
        {
            var inputData = _contex.InputDatas.FirstOrDefault(x => x.id == variant);

            var model = new TestPageModel
            {
                InputData = inputData,
              
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var inputData = _contex.InputDatas.FirstOrDefault(x => x.id == id);

            if (inputData != null)
            {
                _contex.InputDatas.Remove(inputData);
                _contex.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
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
}