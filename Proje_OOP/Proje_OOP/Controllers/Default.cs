using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class Default : Controller
    {
        //void islemler()
        //{
        //	Class1 class1 = new Class1();
        //	class1.topla();
        //	class1.carp();
        //}

        void messages()
        {
            ViewBag.message1 = "Bu bir core projesi";
            ViewBag.message2 = "Dünya salam";
            ViewBag.message3 = "ju ma pel metehan";

        }

        int topla()
        {
            int s1 = 5;
            int s2 = 3;
            int s3 = s1 + s2;
            return s3;
        }

        string cumle()
        {
            string c = "Selam";
            return c;
        }



        public IActionResult Index()
        {
            messages();
            return View();
        }
        public IActionResult Urunler()
        {
            ViewBag.t = topla();
            messages();
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.c = cumle();
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler s = new Sehirler();

            s.Ad = "Kiev";
            s.ID = 1;
            s.Nufus = 10000000;
            s.SetUlke("Ukranya");
            s.Renk1 = "Mavi";
            s.Renk2 = "Sarı";

            ViewBag.v1 = s.Ad;
            ViewBag.v2 = s.Nufus;
            ViewBag.v3 = s.ID;
            ViewBag.v4 = s.GetUlke();
            ViewBag.v5 = s.Renk1;
            ViewBag.v6= s.Renk2;

            //-------------------------------------------//

            s.Ad = "Üsküp";
            s.ID = 3;
            s.Nufus = 150000;
            s.SetUlke("Karabağ");

            ViewBag.z1 = s.ID;
            ViewBag.z2 = s.GetUlke();
            ViewBag.z3 = s.Ad;
            ViewBag.z4 = s.Nufus;

            return View();
        }


    }
}
