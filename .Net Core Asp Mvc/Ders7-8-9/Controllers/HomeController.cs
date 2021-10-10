using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.baslik = "Merhaba kİtap sayfamıza hoşgeldiniz";
            return View();
        }

        public int Index3()
        {
            return 25;
        }
        public string Index4()
        {
            return "Merhaba bugün hava iyi";
        }

        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){ID=1,KitapAd="80 Günde Devri Alem",Yazar="Jules Verne"},
                new Kitap(){ID=2 ,KitapAd="Bilinmeyen Bir Kadının Mektubu",Yazar="Zweig"},
                new Kitap(){ID=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickens"}
            };            
            return View(ktp);
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }

        public IActionResult Index9()
        {
            return View();
        }
    }
}
