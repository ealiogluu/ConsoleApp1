using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Publisher
    {
        public string PublishName;

        public static List<Publisher> Publishers = new List<Publisher>();
        public Publisher(string publishName)
        {
            PublishName = publishName;

            Publisher publish1 = new Publisher("Can Yayınları");
            Publisher publish2 = new Publisher("İş Bankası Yayınları");
            Publisher publish3 = new Publisher("Timaş çocuk Yayınları");
            Publisher publish4 = new Publisher("Doğan Kitap Yayınları");
            Publisher publish5 = new Publisher("Yapı Kredi Yayınları");
            Publisher publish6 = new Publisher("Timaş Yayınları");
            Publisher publish7 = new Publisher("İthaki Yayınları");
            Publisher publish8 = new Publisher("Dergah Yayınları");
            Publisher publish9 = new Publisher("HAYY Kitap Yayınları");
            Publisher publish10 = new Publisher("Everest Yayınları");
            Publisher publish11 = new Publisher("Kırmızı Kedi Yayınları");

            Publishers.Add(publish1);
            Publishers.Add(publish2);
            Publishers.Add(publish3);
            Publishers.Add(publish4);
            Publishers.Add(publish5);
            Publishers.Add(publish6);
            Publishers.Add(publish7);
            Publishers.Add(publish8);
            Publishers.Add(publish9);
            Publishers.Add(publish10);
            Publishers.Add(publish11);
        }
    }
}
