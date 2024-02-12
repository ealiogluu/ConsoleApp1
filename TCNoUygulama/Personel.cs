using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCNoUygulama
{
    public class Personel
    {

        private string TCKimlikNo;

        public string TCKİmlikNo
        {
            get
            {
                return TCKimlikNo.Substring(0, 5)+"******";
            }
            set 
            {
                bool kontrol = true; ;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool isitnumber= char.IsNumber(value[i]);
                        if (isitnumber== true) {
                        }
                        else
                        {
                            kontrol = false;
                            break;
                        }

                            }

                    if (kontrol==false)
                    {
                        Console.WriteLine("Lütfen gecerli karakterlerle tc nonuzu giriniz.");
                    
                    }
                    else
                    {
                        TCKimlikNo = value; 
                    }
                    

                }
                else Console.WriteLine("Girfiginiz Tc no 11 karakter icermelidir.");
            
            }

        }


    }
}
