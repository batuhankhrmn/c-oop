using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Nesne Yönelimli Programlama Nedir?
            //Nesne nedir?
            //Araba kalıbı ve farklı arabalar
            //TC kimlik şartı şablonu
            #endregion

            #region 2. Sınıf Nedir ve Neden Sınıf Kullanılır?
            //Bir nesne oluşturulması için önce modellenmesi gerekir.
            //Modelleme yapabilmek için class kullanmalıyız.
            #endregion

            #region 4. Sınıf Modelinden Referans Noktası Oluşturma
            //transkriptHesapla t;
            //OrnekModel m;
            #endregion

            #region 5. Class Member

            #region Field
            //myclass m1 = new myclass();
            //m1.a = 1;
            //m1.b = "2";
            #endregion

            #region Property
            //Nesne içerisindeki field lar için bir validasyon katmanıdır.
            //myclass2 m2 = new myclass2();
            //Get blogu tetiklenecek.
            //Console.WriteLine(m2.Yasi);

            //Set blogu tetiklenecek
            //m2.Yasi = 3;
            //Get blogu tetiklenecek
            //Console.WriteLine(m2.Yasi);
            #endregion

            #endregion

            #region Örnek1
            //gecmeNotuHesapla g = new gecmeNotuHesapla();
            //g.not1 = 99;
            //g.not2 = 6;

            //Console.WriteLine(g.ortalamaHesapla());
            //Console.ReadLine();
            #endregion

            #region 6. Prop Property
            //Prop Property'de field tanımlamaya gerek yoktur.
            //myclass3 m3 = new myclass3();
            //Console.WriteLine(m3.Yas1);
            //Console.WriteLine(m3.Yas2);
            //Console.ReadLine();
            #endregion

            #region 7. Computed Property
            //myclass4 m4 = new myclass4();
            //Console.WriteLine(m4.Topla);
            #endregion

            #region Örnek2
            //fiyat f = new fiyat();
            //Console.WriteLine(f.UrunSonFiyat);
            //Console.ReadLine();
            #endregion

            #region 8. Experession-Bodied Property
            //Prop'tan sadece değer dönen yapılardır.Sadece readonlydir.
            //myclass5 m5 = new myclass5();
            //Console.WriteLine(m5.Cinsiyet);
            //Console.ReadLine();
            #endregion

            #region 9. Metodlar
            //myclass9 m9 = new myclass9();
            //Parantez ile birlikte çağrılır.
            //Console.WriteLine(m9.x());
            //Console.ReadKey();
            #endregion

            #region 10. Sınıf İçinde Sınıf Kullanımı
            //myclass6 m6 = new myclass6();

            //myclass6.myclass6_1 m6_1 = new myclass6.myclass6_1();
            #endregion

            #region 11. Sınıf Elemanlarına Açıklama Satırı Ekleme
            //myclass7 m67 = new myclass7();
            //m67.yas = 7;
            //m67.maasHesapla(4200);
            #endregion

            #region 12. This Keyword'ü
            //Sınıfın nesnesini temsil eder, metod ile field isimlerinin karışmasını engeller.
            myclass8 m8 = new myclass8();
            #endregion

            #region 13. Sorular
            //Basit bir banka hesabı işlemleri

            //Banka2 b = new Banka2();

            //Console.WriteLine("Güncel bakiye:" + b.hesapBakiyesi());

            //b.paraYatir(200);
            //Console.WriteLine("Para yatırma işlemi sonunda bakiye:" + b.Bakiye);

            //b.paraCek(150);
            //Console.WriteLine("Para çekme işlemi sonunda bakiye:" + b.Bakiye);
            //Console.ReadLine();



            //Çalışan sınıfı oluşturun bu sınıfın çalışan adı, departmanı, aylık maaş bilgileri gibi özellikleri olsun. Ayrıca maaş artışı yapılacak bir metod içersin.
            //calisan c = new calisan();
            //Console.WriteLine("Çalışanın adı:" + c.Adi);
            //Console.WriteLine("Çalışanın departmanı:" + c.Departmani);
            //Console.WriteLine("Çalışanın güncel maaşı:" + c.Maas);
            //c.maasArtisi(0.1);
            //Console.WriteLine("Zamdan sonra maaş:" + c.Maas);
            //Console.ReadLine();



            //Girilen sayının faktöreyelini hesaplayan bir sınıf ve metod oluşturunuz.
            //faktoriyel f = new faktoriyel();
            //f.Sayi = 5;
            //Console.WriteLine("Faktoriyel: " + f.faktoriyelHesaplama(f.Sayi));
            //Console.ReadLine();


            //Bir pizza sipariş uygulaması, pizza sınıfı oluşturalım pizzanın boyutu, malzemeleri, fiyatı gibi özellikleri içersin sipariş verme ve ödeme işlemlerini gerçekleştirebilecek metodları yazalım. 
            //Pizza pizza = new Pizza();
            //Console.WriteLine("Pizzanızın tür numarasını giriniz:");
            //pizza.pizzaTurNo = int.Parse(Console.ReadLine());
            //pizza.pizzaBoyutu = "Orta Boy";
            //Console.WriteLine("Lütfen adresinizi giriniz:");
            //string adres = Console.ReadLine();
            //Console.WriteLine("Lütfen ödeyeceğiniz miktarı giriniz:");
            //double odenenPara = int.Parse(Console.ReadLine());
            //pizza.siparisVer(pizza.pizzaTurNo,pizza.pizzaBoyutu, adres, odenenPara);
            //Console.ReadLine();
            #endregion

            #region 14. Init-Only Proporties
            //Sadece intialize edilirken değer alabilir.
            //myclass9 m9 = new myclass9
            //{
            //    x = 5
            //};

            //m9.x = 4;
            #endregion

            #region 15. Record
            //Record, bir objenin topyekün olarak sabit/değişmez olarak kalmasını sağlamakta ve bu durumu güvence altına almaktadır.
            //Böylece bu obje, artık değeri değişmeyeceğinden dolayı esasında objeden ziyade bir değer gözüyle bakılan bir yapıya dönüşmektedir.
            //Buradan yola çıkarak, record'ları içerisinde data barındıran lightweight(hafif) class'lar olarak değerlendirebiliriz.
            //Employee calisan1 = new Employee();
            //{
            //    Name = "Batuhan",
            //    Surname = "Kahraman",
            //    Position = 1
            //};

            //Employee calisan2 = new Employee();
            //{
            //    Name = calisan1.Name,
            //    Surname = calisan1.Surname,
            //    Position = 2
            //};
            #endregion

            #region 16. Constructor Metod
            //Bir classta bir nesne oluştururken her şeyden önce ilk olarak çalışan yapılardır.
            //Constructorlar public olmalıdırlar.Class ismi ile aynı olmalıdırlar.Metodlara benzer ama geri dönüş tipi yoktur.
            car ford = new car(); //Create an object of the car class (this will call the constructor)
            Console.WriteLine(ford.model); //Print value of model
            #endregion

            #region Not Hesaplama
            //2 vize + 1 final notu içeren değişkenler olmalı. Geçme notunu hesaplayıp, geçme durumunu dönen bir hesaplama sınıfı yazın.
            //notHesaplama nh = new notHesaplama();
            //Console.WriteLine("İlk vize notunu giriniz:");
            //nh.vize1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci vize notunu giriniz:");
            //nh.vize2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Final notunu giriniz:");
            //nh.final = int.Parse(Console.ReadLine());
            //nh.gecmeHesaplama(nh.vize1, nh.vize2, nh.final);
            //Console.ReadLine();
            #endregion
        }
    }
    #region 17. Destructor Metod
    //Destructor kısaca constructorın tam tersidir.
    //Constructor için bir nesnenin istance'i alınırken ram'de ki Heap bölümünde yer ayırmadan önce çağrılan metod diyebiliriz.
    //Destructor tam bu nesne ram'den silinmeden önce çağrılan metod olur.
    //Class kapanmandan önce son olarak çalışan metodtur.

    class Person
    {

        ~Person() //destructor
        {
            //cleanup statements...
        }
    }
    #endregion

    #region 18. Static Constructor
    //Static constructor o sınıftan sadece ilk nesne üretildiğinde çalışır.
    //Daha sonraki nesne üretme aşamlarında çağrılmaz. Static constructor kendine has özellikleri vardır.

    //Static constructor herhangi bir access modifier almaz.
    //Static constructor herhangi bir parametre almaz.
    //Static constructor sadece ilk nesne üretme esnasında otomatik çağrılır.
    //Static constructor direkt çağırılmaz.
    //Bir sınıfta sadece bir tane static constructor olabilir.
    //Static constructor sadece sınıfın static elemenlarına erişebilir.

    //public class Araba
    //{
    //    public int yas;
    //    public string adi;

    //    static Araba() //Static constructor parametre almaz ve access identifier'i olmaz.
    //    {
    //        this.adi = "Ford";
    //    }
    //}
    //Araba nesne1 = new Araba();
    //Console.WriteLine(nesne1.adi); // Sadece ilk nesne üretildiğinde setlenecek
    //Araba nesne2 = new Araba(); //Burası boş
    #endregion

    #region 19. Kalıtım
    //Inheritance (kalıtım), nesne yönelimli programlamanın en temel unsurlarından biridir.
    //Kalıtım hiyerarşik sınıflandırma olanağı sağlar.
    //Kalıtım kullanarak birbiri ile ilişkili bir grup nesnenin ortak özelliklerini tanımlayan temel bir sınıf oluşturabiliriz.
    //Bu temel sınıf daha sonra belirli sınıflara kalıtım yoluyla aktarılır.

    //Ornek1
    //Kedi k = new Kedi();
    //k.ad = "Nisa";
    //k.boy = 35;
    //k.kuyrukVarMi = true;

    //Ornek2
    //Ucgen ucgen = new Ucgen();
    //ucgen.genislik = 10;
    //ucgen.yukseklik = 2;

    //ucgen.Goster();
    //Console.WriteLine("Üçgenin alanı: " + ucgen.Alan());
    #endregion

    #region 20. Abstraction
    //Karmaşıklığı yönetmek için kullanılır.
    //Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir,
    //böylece izleyicinin bakış açısından açıkça tanımlanmış bir kavramsal sınır sağlar.

    //Örnegimizde soyut bir MobilePhone sınıfı oluşturulmuş bulunmaktadır.
    //Bu abstract sınıfa ait iki adet metod bulunmaktadır. Bunlar arama yapmak için kullanılan,
    //Calling() ve mesaj gönderebilmek için kullanılan SendSMS() metodlarıdır. Ardından cep telefonu
    //modellerini içeren sınıflar bu abstract sınıftan türetilmiş bulunmaktadır. Yeni türetilen modele
    //ait sınıflar abstract class’ı kullanmaktadır. Çünkü tüm modeller için,
    //abstract sınıftaki arama yapmak ve mesaj göndermek temel fonksiyonlardır.
    //abstract class MobilePhone
    //{
    //    public void Calling();
    //    public void SendSMS();
    //}

    //public class Samsung : MobilePhone
    //{

    //}
    //public class Nokia2700 : MobilePhone
    //{
    //    public void FMRadio();
    //    public void MP3();
    //    public void Camera();
    //}
    //public class BlackBerry : MobilePhone
    //{
    //    public void FMRadio();
    //    public void MP3();
    //    public void Camera();
    //    public void Recording();
    //    public void ReadAndSendEmails();
    //}
    #endregion

    #region 21. Interface
    //Interfaceler, kendisinden kalıtım alan sınıfların içinde olması zorunlu olan yapıları tanımlarlar.
    //Tek görevleri budur.Interfaceler bu yönleriyle abstract classlara benzerler.Ancak abstract class içerisinde,kendisinden kalıtım alan sınıfta yazılması zorunlu olmayacak yapılar da tanımlanabilir.
    //Fakat interface tanımlanan herşey, kalıtımı alan sınıfta uygulanmak zorundadır.

    //Arayüzler, sınıflara rehberlik etmek üzere oluşturulan nesneye dayalı programlamanın en önemli özelliklerinden biridir
    //Sınıfların hangi metotları ve özellikleri içermesi gerektiğini arayüzler içerisinde bildiriyoruz.
    //Arayüzler “interface” anahtar sözcüğü ile oluşturulur. Zorunlu olmamakla birlikte arayüz isimleri genellikle “I” harfiyle başlatılır.
    //Böylece “I” ön ekini gören bir programcı onun bir arayüz olduğunu anlar. Arayüz içerisinde özelliklerin ve
    //metotların sadece bildirimi yapılır. Yani herhangi bir şekilde özelliklere bir değer atanmaz sadece türleri ve
    //isimleri yazılır, aynı şekilde metotların içerisine kodlar yazılmaz sadece geri dönüş türleri ve isimleri yazılır.

    interface IKisi
    {
        string adSoyad {get; set; }
        string adres { get; set; }
        string departman { get; set; }
        void bilgi();
    }
    class Yonetici : IKisi
    {
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public void bilgi()
        {
            Console.WriteLine("{0} isimli çalışan {1} departmanında yöneticidir.", adSoyad, departman);
            Console.ReadLine();
        }
    }
    #endregion

    #region 3. Sınıf Oluşturma ve Konumları
    // Bir sınıf namespace içinde, dışında yada bir sınıf içinde oluşturulabilir.
    // Aynı yerde aynı isimle 2 sınıf olamaz!

    class OrnekModel
    {
        int a;
        int b;
        public void X()
        {
            Console.WriteLine(a); Console.WriteLine(b);
        }
        public int Y()
        {
            return 0;
        }
    }
    #endregion


    class transkriptHesapla
    {
        public int a;
        public string b;
        public string c;
    }

    class myclass
    {
        public int a;
        public string b;
    }

    class myclass2
    {
        int yasi;

        #region Full Property
        //Property hangi field'ı temsil ediyorsa onun türünden olmalı.
        //Property adı temsil ettiği field'iın baş harfi büyük olacak şekilde isimlendirilir.

        public int Yasi
        {
            get
            {
                return yasi;
            }

            set
            {
                yasi = value;
            }
        }

        #endregion
    }

    class gecmeNotuHesapla
    {
        public int not1;
        public int not2;

        public int ortalamaHesapla()
        {
            return (not1 + not2) / 2;
        }
    }

    class myclass3
    {
        //Prop Property'de field tanımlamaya gerek yoktur.
        //int yasi = 5;

        public int Yas1 { get; set; }

        //Oluşturacağın filed'ın ilk değeri 15 olsun.
        public int Yas2 { get; set; } = 15;
    }

    class myclass4
    {
        int sayi1 = 15;
        int sayi2 = 45;
        public int Topla
        {
            get
            {
                return sayi1 + sayi2;
            }
        }
    }

    class fiyat
    {
        public int urunFiyat = 825;
        public int kdv = 20;
        public int UrunSonFiyat
        {
            get
            {
                return ((urunFiyat * kdv) / 100) + urunFiyat;
            }
        }
    }

    class myclass5
    {
        public String Cinsiyet => "Erkek";
    }

    class myclass9
    {
        public int a;
        public string b;

        public int x()
        {
            return 10;
        }
    }

    class Banka
    {
        int bakiye;

        public int Bakiye
        {
            get
            {
                if (bakiye > 0) { return bakiye * 10; }
                return 5;
            }
            set
            {
                if (value < 10)
                {
                    bakiye = value;
                }
                else
                {
                    bakiye = value * 95 / 100;
                }
            }
        }
    }

    class myclass6
    {
        int a;

        public int A { get; set; }

        public class myclass6_1
        {

        }
        /// <summary>
        /// Bu sınıf kdv hesaplaması yapar. 
        /// </summary>           
    }

    class myclass7
    {
        int maas;

        ///<summary>
        ///Bu bir yaş propertysidir.
        ///</summary>
        public int yas { get; set; }

        ///<summary>
        ///Bu metod ödenecek maaşı hesaplar.
        ///</summary>
        ///<param name="yalinMaas"></param>
        ///<returns>Ek ödemeli maaş bilgisini hesaplar.</returns>
        public double maasHesapla(double yalinMaas)
        {
            return yalinMaas + 100;
        }
    }

    class myclass8
    {
        int yas;

        public double yasHesapla(int yas)
        {
            return this.yas + yas;
        }
    }

    class Araba
    {

    }

    class Hesaplama
    {

    }

    class musteri
    {

    }

    class Banka2
    {

        public double Bakiye
        {
            get; set;
        } = 100;

        public double hesapBakiyesi()
        {
            return Bakiye;
        }

        public void paraCek(double cekilecekTutar)
        {
            if (cekilecekTutar <= Bakiye)
            {
                Bakiye = Bakiye - cekilecekTutar;
            }
        }
        public void paraYatir(double yatiralacakTutar)
        {
            Bakiye = Bakiye + yatiralacakTutar;
        }
    }

    class calisan
    {
        public string Adi { get; set; } = "Batuhan";
        public string Departmani { get; set; } = "Yazılım Departmanı";
        public double Maas { get; set; } = 54000;

        public void maasArtisi(double arttirilacakTutar)
        {
            Maas = Maas + (Maas * arttirilacakTutar);
        }
    }

    class faktoriyel
    {
        public int Sayi { get; set; }

        public int faktoriyelHesaplama(int deger)
        {
            int sonuc = 1;
            for (int i = 1; i <= Sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }

    //class myclass9
    //{
    //    public int x { get; init; } = 3;
    //}

    //public record Employee
    //{
    //    public string Name { get; init; }
    //public string Surname { get; init; }
    //public int Position { get; init; }

    //}

    class car
{
    public string model; //Create a field

    //Create a class constructor for the car class
    public car()
    {
        model = "Mustang"; //Set the initial value for model.
    }
}

    class Pizza
    {
        public string pizzaBoyutu { get; set; } = "Orta Boy";
        public int pizzaTurNo { get; set; } = 2;
        public double pizzaFiyat { get; set; } = 150;

        public void siparisVer(int pizzaNo, string boyut, string adres, double odenenPara)
        {
            if (odenenPara == pizzaFiyat)
            {
                Console.WriteLine(pizzaNo + " numaralı " + boyut + " pizzanız, " + adres + " adresine gönderilecektir. ");
            }
            else
            {
                Console.WriteLine("Lütfen pizza fiyatına eşit bir miktarda ödeme yapınız.");
            }
        }
    }

    class notHesaplama
    {
        public double vize1 {  get; set; }
        public double vize2 { get; set;}
        public double final { get; set;}
        public void gecmeHesaplama(double vize1, double vize2, double final)
        {
            double ortalama = (vize1 * 0.2) + (final * 0.6) + (vize2 * 0.2);
            if (ortalama < 50 && ortalama > 0)
            {
                Console.WriteLine("Kaldınız " + ortalama);
            }
            else if (ortalama >= 50 && ortalama <= 100)
            {
                Console.WriteLine("Geçtiniz " + ortalama);
            }
            else
            {
                Console.WriteLine("Hatalı not girişi");
            }
        }
    }

    public class Hayvan
    {
        public string ad { get; set; }
        public decimal boy { get; set; }
        public bool kuyrukVarMi { get; set; }

        public string Mesaj()
        {
            return "Hayvanları sevelim...beni evde besleyebilirsiniz.";
        }
    }

    public class Kedi: Hayvan
    {

    }

    public class Sekil
    {
        public double genislik;
        public double yukseklik;
        public void Goster()
        {
            Console.WriteLine("Genişlik: " + genislik + ", Yükseklik: " + yukseklik);
        }
    }

    public class Ucgen: Sekil
    {
        public string adi;
        public double Alan()
        {
            return genislik * yukseklik / 2;
        }
    }
}