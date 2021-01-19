Merhaba Arkadaşlar,

 

Bu yazımızda sizlere .Net MVC projesi ile AngularJS kullanarak Infinity Scroll(Sonsuz kaydırma) kullanımının kolay ve hızlı bir yöntemini kodlayarak göstereceğim.

 

İlk olarak Visual Studio programını açarak web bölümünden boş bir Asp.NET MVC projesi başlatıyorum. 

Projeyi başlattıktan sonra ilk işlem olarak Solution Explorer üzerinden projemize sağ tıklayarak Manage Nuget Pakages üzerinden AngularJS yazarak arama yapıp aşağıda görseldeki gibi gelen kütüphaneyi install ederek projemize dahil ediyoruz.

 

Projemize AngularJS kütüphanesini ekledikten sonra model olarak kullanacağımız Kitap isimli class'ımızıda Models isimli klasörümüz altına ekliyoruz.

 

    public class Kitap

    {

        public int ID { get; set; }

        public string Ad { get; set; }

        public string Yazar { get; set; }

    }

 

 

Modelimizide eklediğimize göre Controller klasörümüz içerisine oluşturacağımız HomeController isimli Controllerımızın içeriğini kodlamaya geçebiliriz.

Projemiz içerisinde bir veri tabanı bağlantısı kullanmayacağımız için Kitap isimli modelimizi List şeklinde kullanarak bir liste yapısı oluşturup içeriğini aşağıdaki gibi Kitap class'ımızdan instancelar alarak dolduruyoruz.

Siz kendi projelerinizde kullanırken bir veri tabanı bağlantısı yapıp  tablolarınızdaki verileri ekrana getirerek kullanabilirsiniz.

 

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

 

 

Yukarıda paylaştığım HomeController kodlarımız içerisinde AngularJS ile kullanacağımız KitaplariGetir isimli metodumuzu sayfaNo alacak şekilde kodluyoruz. Bu metodumuz JsonResult şeklinde olduğu için AngularJS ile asenkron bir şekilde haberleşecek ve parametre olarak gönderilen sayfaNo ile birlikte istenilen verileri ekrana getirmemizi sağlayacaktır.

 

HomeController içerisinde kodladığımız Index isimli ActionResult'umuzun View'ını oluşturarak içeriğini aşağıdaki gibi kodluyoruz.

 

 

@{

    ViewBag.Title = "Index";

    Layout = "~/Views/Shared/_Layout.cshtml";

}

 

<div class="container">

    <h2>AngularJS Infinity Scroll Kullanımı</h2>

    <div ng-app="myApp" ng-controller="InfinityScrollController">

        <div style="position:relative">

            <span ng-show="IsLoading" class="loading">Bekleniyor...</span>

            <div infinityscroll="NextPage()" style="height:500px; overflow:auto;">

                <table class="table table-responsive table-striped table-bordered">

                    <thead>

                        <tr>

                            <th>id</th>

                            <th>Kitap Adı</th>

                            <th>Yazar</th>

                        </tr>

                    </thead>

                    <tbody>

                        <tr ng-repeat="k in BookList" style="height:100px;">

                            <td>{{k.ID}}</td>

                            <td>{{k.Ad}}</td>

                            <td>{{k.Yazar}}</td>

                        </tr>

                    </tbody>

                </table>

            </div>

        </div>

    </div>

</div>

 

 

<script src="~/Scripts/angular.min.js"></script>

 

<script>

 

    var app = angular.module('myApp', []);

    app.controller('InfinityScrollController', ['$scope', '$http', function ($scope, $http) {

        $scope.CurrentPage = 1;

        $scope.TotalPage = 0;

        $scope.BookList = [];

 

        function GetKitapData(page) {

            $scope.IsLoading = true;

            $http({

                method: 'GET',

                url: '/Home/KitaplariGetir',

                params: { 'sayfaNo': page }

            }).then(function (response) {

                angular.forEach(response.data.List, function (value) {

                    $scope.BookList.push(value);

                });

                $scope.TotalPage = response.data.totalPage;

                $scope.IsLoading = false;

            }, function () {

                $scope.IsLoading = false;

            })

        }

 

        GetKitapData($scope.CurrentPage);

 

        $scope.NextPage = function () {

            if ($scope.CurrentPage < $scope.TotalPage) {

                $scope.CurrentPage += 1;

                GetKitapData($scope.CurrentPage);

            }

        }

    }]);

 

 

    app.directive('infinityscroll', function () {

        return {

            restrict: 'A',

            link: function (scope, element, attrs) {

                element.bind('scroll', function () {

                    if ((element[0].scrollTop + element[0].offsetHeight) == element[0].scrollHeight) {

 

                        scope.$apply(attrs.infinityscroll)

                    }

                });

            }

        }

    });

 

</script>

 

 

<style type="text/css">

    .loading {

        position: absolute;

        left: 48%;

        top: 48%;

        display: block;

        padding: 25px;

        background-color: yellow;

        color: red;

        border: 1px solid;

        margin: 0 auto;

    }

</style>

 

 

Index View'ımızda AngularJS eklentimizi kullanmak için yukarıdaki kod bloğunda gördüğünüz gibi angular.min.js kütüphanesini ekleyip infinityscroll özelliklerini kullanmak için angular controller'ımızı ekleyip içerisinde GetKitapData isimli bir function kullanarak HomeController içerisinde JsonResult metot olarak oluşturduğumuz KitaplariGetir metodumuzdan verilerimizi okuyoruz.

 

Son olarak ise AngularJS kodlamamız içerisinde bulunduğumuz div elementimizin scroll yapıldığında sayfa sonuna geldiğini anlamamız için bir directive yapısı kodluyoruz.Bu directive sayesinde div içindeli scroll sayfa sonuna geldiğinde JsonResult olarak hazırladığımız metodu çağırıp ekrana verilerimizi getirebileceğiz.

 

View'ımızın en altında ise verilerimizi getirirken kullandığımız ekranda çok hızlı görünüp kaybolan ama veri kümemiz büyüdükçe verilerin gelmesini beklerken kullanacağımız bir loading divi ekleyip onun css kodlamalarını yapıyoruz. Böylelikle verilerimiz ekrana gelirken en azından uzun bir süre gerekirse kullanıcıların verilerin yüklenmeye çalıştığını anlamalarını sağlıyoruz.

 

Kodlamalarımızı bu şekilde bitirdikten sonra artık projemizi derleyip çalıştırabiliriz.Projemiz çalıştığında ekranımızda scroll yaptığımızda verilerimizin yüklenerek ekrana geldiğini görebiliriz.

 

 
