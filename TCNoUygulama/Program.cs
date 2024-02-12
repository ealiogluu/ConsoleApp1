using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// personelin tc nosunu alıp kontrollerden geçirme
//set şartları
//1-tc no 11 karakter olmalı
//2-sayısal karakterler olmalı
//get şartaşrı
//tc nosu ilk 5 karakteri alınacak


namespace TCNoUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personel personel1 = new Personel();

            personel1.TCKİmlikNo = "12345678912";

            Console.WriteLine(personel1.TCKİmlikNo);


        }
    }
}
