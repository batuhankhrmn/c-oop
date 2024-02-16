using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            fiyat f = new fiyat();
            Console.WriteLine(f.UrunSonFiyat);
            Console.ReadLine();
            #endregion
        }
    }
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
                return sayi1 + sayi2 ;
            }
        }
    }

    class fiyat
    {
        public int urunFiyat = 525;
        public int kdv = 20;
        public int UrunSonFiyat
        {
            get
            {
                return ((urunFiyat * kdv)/100) + urunFiyat;
            }
        }
    }
}