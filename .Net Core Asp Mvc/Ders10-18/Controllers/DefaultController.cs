using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitaplikProjesi.Models;

namespace KitaplikProjesi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1,KitapAd="Satranç",Yazar="Zweig"},
                new Kitaplar(){ID=2,KitapAd="Dr Oxun Deneyi",Yazar="Jules Verne"},
                new Kitaplar(){ID=3,KitapAd="Deli Fişek",Yazar="Vacenceulos"},
                new Kitaplar(){ID=4,KitapAd="Kırmızı Bisiklet",Yazar="Muzaffer İzgü"},
                new Kitaplar(){ID=5,KitapAd="Toros Canavarı",Yazar="Aziz Nesin"}
            };
            return View(ktp);
        }

        public IActionResult deneme()
        {
            return View();
        }
        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
