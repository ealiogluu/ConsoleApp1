using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulama
{
    public class Ogrenci
    {
        //İsim soyisim vize1 vize2 final  okul ismi

        //ogrenci bilgileri goster +
        //ortalama goster 
        //ogrencş okulu ogren
        //çıkış yap

        private int OgrenciNo;

        private string OgrenciIısım;
        private string OgrenciSoyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string OkulIsmı;

        public Ogrenci(int _ogrenciNo,string _ogrenciIsım, string _ogrenciSoyisim, int _vize1, int _vize2,int _final, string _okulIsmı)
        {
            OgrenciNo = _ogrenciNo;
            OgrenciIısım = _ogrenciIsım;
            OgrenciSoyisim= _ogrenciSoyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            OkulIsmı = _okulIsmı;



        }
        

    

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci Numarasi: " + OgrenciNo);
            Console.WriteLine("Ogrenci isim: " + OgrenciIısım);
            Console.WriteLine("Ogrenvi Soyisim: " + OgrenciSoyisim);
            Console.WriteLine("Ogrencinin okulıu: " + OkulIsmı);

            Console.WriteLine("Notlar: ");
            Console.WriteLine("********");

            Console.WriteLine("Vize 1: " + vize1);
            Console.WriteLine("Vize 2: " + vize2);
            Console.WriteLine("Final: " + final);

        }

        public double OgrenciNotuBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

            return ortalama;
        }

        public void OkulBul()
        {
            Console.WriteLine("Ogrencinin okulu: " + OkulIsmı);
        }




    }
}
