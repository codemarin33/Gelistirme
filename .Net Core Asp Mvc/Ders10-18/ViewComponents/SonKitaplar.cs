using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitaplikProjesi.Models;


namespace KitaplikProjesi.ViewComponents
{
    public class SonKitaplar: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitapllistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,
                    KitapAd="Korku",
                    Yazar= "Zweig"
                },
                new Kitaplar
                {
                    ID=7,
                    KitapAd="Anna Karanina",
                    Yazar="Tolstoy"
                }
            };
            return View(kitapllistesi);
        }
    }
}
