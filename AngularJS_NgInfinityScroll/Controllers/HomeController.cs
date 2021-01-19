using AngularJS_NgInfinityScroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS_NgInfinityScroll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult KitaplariGetir(int sayfaNo)
        {

            List<Kitap> Kitaplar = new List<Kitap>();

            Kitap kitap1 = new Kitap();
            kitap1.ID = 1;
            kitap1.Ad = "Nutuk";
            kitap1.Yazar = "Mustafa Kemal Atatürk";
            Kitaplar.Add(kitap1);

            Kitap kitap2 = new Kitap();
            kitap2.ID = 2;
            kitap2.Ad = "Çalıkuşu";
            kitap2.Yazar = "Reşat Nuri Gültekin";
            Kitaplar.Add(kitap2);

            Kitap kitap3 = new Kitap();
            kitap3.ID = 3;
            kitap3.Ad = "Şeker Portakalı";
            kitap3.Yazar = "Jose Mauro De Vasconcelos";
            Kitaplar.Add(kitap3);

            Kitap kitap4 = new Kitap();
            kitap4.ID = 4;
            kitap4.Ad = "Sefiller";
            kitap4.Yazar = "Victor Hugo";
            Kitaplar.Add(kitap4);

            Kitap kitap5 = new Kitap();
            kitap5.ID = 5;
            kitap5.Ad = "Don Kişot";
            kitap5.Yazar = "Cervantes";
            Kitaplar.Add(kitap5);

            Kitap kitap6 = new Kitap();
            kitap6.ID = 6;
            kitap6.Ad = "Mai ve Siyah";
            kitap6.Yazar = "Halit Ziya Uşaklıgil";
            Kitaplar.Add(kitap6);

            Kitap kitap7 = new Kitap();
            kitap7.ID = 7;
            kitap7.Ad = "Mor Salkımlı Ev";
            kitap7.Yazar = "Halide Edib Adıvar";
            Kitaplar.Add(kitap7);

            Kitap kitap8 = new Kitap();
            kitap8.ID = 8;
            kitap8.Ad = "Savaş ve Barış";
            kitap8.Yazar = "Tolstoy";
            Kitaplar.Add(kitap8);

            Kitap kitap9 = new Kitap();
            kitap9.ID = 9;
            kitap9.Ad = "Vadideki Zambak";
            kitap9.Yazar = "Balzac";
            Kitaplar.Add(kitap9);

            Kitap kitap10 = new Kitap();
            kitap10.ID = 10;
            kitap10.Ad = "Sergüzeşt";
            kitap10.Yazar = "Samipaşazade Sezai";
            Kitaplar.Add(kitap10);

            Kitap kitap11 = new Kitap();
            kitap11.ID = 11;
            kitap11.Ad = "Kürk Mantolu Madonna";
            kitap11.Yazar = "Sabahattin Ali";
            Kitaplar.Add(kitap11);

            Kitap kitap12 = new Kitap();
            kitap12.ID = 12;
            kitap12.Ad = "Tom Sawyer";
            kitap12.Yazar = "Mark Twain";
            Kitaplar.Add(kitap12);

            Kitap kitap13 = new Kitap();
            kitap13.ID = 13;
            kitap13.Ad = "Oliver Twist";
            kitap13.Yazar = "Charles Dickens";
            Kitaplar.Add(kitap13);

            Kitap kitap14 = new Kitap();
            kitap14.ID = 14;
            kitap14.Ad = "Robin Hood";
            kitap14.Yazar = "Howard Pyle";
            Kitaplar.Add(kitap14);

            Kitap kitap15 = new Kitap();
            kitap15.ID = 15;
            kitap15.Ad = "Pinokyo";
            kitap15.Yazar = "Carlo Collodi";
            Kitaplar.Add(kitap15);

            Kitap kitap16 = new Kitap();
            kitap16.ID = 16;
            kitap16.Ad = "Seksen Günde Devr-i Alem";
            kitap16.Yazar = "Jules Verne";
            Kitaplar.Add(kitap16);

            Kitap kitap17 = new Kitap();
            kitap17.ID = 17;
            kitap17.Ad = "Pollyanna";
            kitap17.Yazar = "Eleanor Porter";
            Kitaplar.Add(kitap17);

            Kitap kitap18 = new Kitap();
            kitap18.ID = 18;
            kitap18.Ad = "Dokuzuncu Hariciye Koğuşu";
            kitap18.Yazar = "Peyami Safa";
            Kitaplar.Add(kitap18);

            Kitap kitap19 = new Kitap();
            kitap19.ID = 19;
            kitap19.Ad = "İki Şehrin Hikayesi";
            kitap19.Yazar = "Charles Dickens";
            Kitaplar.Add(kitap19);

            Kitap kitap20= new Kitap();
            kitap20.ID = 20;
            kitap20.Ad = "Suç ve Ceza";
            kitap20.Yazar = "Dostoyevski";
            Kitaplar.Add(kitap20);


            int toplamKayitSayisi = 0;
            int toplamSayfaSayisi = 0;
            int gosterilecekKayitSayisi = 5;


            //Yukarıda eklemiş olduğum bütün kitapları ID propertysine göre küçükten büyüğe sıralıyorum.
            Kitaplar = Kitaplar.OrderBy(x => x.ID).ToList();

            toplamKayitSayisi = Kitaplar.Count();

            //Toplam sayfa sayısını gösterilecek kayıt sayısına bölerek sayfa sayımızı buluyoruz. Eğer toplam sayfa sayımızı gösterilecek sayfa sayımızı böldüğümüzde tam sayı değilde küsüratlı bir sonuç alıyorsak o zaman sayfa sayısına aşağıdaki gibi mod işlemini kullanarak fazladan kayıt varsa toplam sayfa sayımıza 1 ekliyoruz.
            toplamSayfaSayisi=(toplamKayitSayisi/gosterilecekKayitSayisi) + ((toplamKayitSayisi % gosterilecekKayitSayisi) > 0 ? 1 : 0);

            List<Kitap> GosterilecekKitaplar = new List<Kitap>();

            GosterilecekKitaplar = Kitaplar.Skip((sayfaNo - 1) * gosterilecekKayitSayisi).Take(gosterilecekKayitSayisi).ToList();

            return new JsonResult { Data = new { List = GosterilecekKitaplar, currentPage = sayfaNo, totalPage = toplamSayfaSayisi }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}