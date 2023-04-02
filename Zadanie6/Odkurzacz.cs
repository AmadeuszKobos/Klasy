using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    internal class Odkurzacz
    {
        public static Odkurzacz operator +(Odkurzacz odkurzacz, Odkurzacz odkurzacz_kopia)
        {
            Odkurzacz odkurzacz_sum = new Odkurzacz();
            odkurzacz_sum.pojemnosc = odkurzacz.pojemnosc + odkurzacz_kopia.pojemnosc;
            odkurzacz_sum.zapelnienie = odkurzacz.zapelnienie/2 + odkurzacz_kopia.zapelnienie/2;
            odkurzacz_sum.producent = odkurzacz.producent + odkurzacz_kopia.producent;
            if(odkurzacz.przewodowy == false)
            {
                odkurzacz_sum.przewodowy = false;
            }
            else if (odkurzacz_kopia.przewodowy == false)
            {
                odkurzacz_sum.przewodowy = false;
            }
            else
            {
                odkurzacz_sum.przewodowy = true;
            }

            return odkurzacz_sum;
        }

        public static bool operator >(Odkurzacz odkurzacz, Odkurzacz odkurzacz_kopia)
        {
            if(odkurzacz.przewodowy == false && odkurzacz_kopia.przewodowy == true)
            {
                return true;
            }
            else if(odkurzacz.przewodowy == true && odkurzacz_kopia.przewodowy == false)
            {
                return false;
            }
            else
            {
                if (odkurzacz.zapelnienie > odkurzacz_kopia.zapelnienie)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator <(Odkurzacz odkurzacz, Odkurzacz odkurzacz_kopia)
        {
            if (odkurzacz.przewodowy == true && odkurzacz_kopia.przewodowy == false)
            {
                return true;
            }
            else if (odkurzacz.przewodowy == false && odkurzacz_kopia.przewodowy == true)
            {
                return false;
            }
            else
            {
                if (odkurzacz.zapelnienie < odkurzacz_kopia.zapelnienie)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private string producent;
        public string Producent
        {
            get { return producent; }
            set { producent = value; }
        }
        private bool przewodowy;
        public bool Przewodowy
        {
            get { return przewodowy; }
            set { przewodowy = value; }
        }
        protected double pojemnosc;
        public double Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value; }
        }
        private double zapelnienie;
        public double Zapelnienie
        {
            get { return zapelnienie; }
            set { zapelnienie = value; }
        }

        public Odkurzacz()
        {

        }
        public Odkurzacz(string producent_p, bool czy_przewodowy, double pojemnosc_odkurzacz, double zapelnienie)
        {
            this.producent = producent_p;
            this.przewodowy = czy_przewodowy;
            this.pojemnosc = pojemnosc_odkurzacz;
            this.zapelnienie = zapelnienie;
        }

        public Odkurzacz(Odkurzacz obiekt)
        {
            this.producent = obiekt.producent;
            this.przewodowy = obiekt.przewodowy;
            this.pojemnosc = obiekt.pojemnosc;
            this.zapelnienie = obiekt.zapelnienie;
        }

        public void Wypisz()
        {
            Console.WriteLine("Producent: " + this.producent);
            if (this.przewodowy == true)
            {
                Console.WriteLine("Odkurzacz jest przewodowy");
            }
            else
            {
                Console.WriteLine("Odkurzacz jest bezprzewodowy");
            }
            Console.WriteLine("Pojemnosc odkurzacza: " + this.pojemnosc + "l");
            Console.WriteLine("Zapelnienie odkurzacza: " + this.zapelnienie + "%");
        }

        public void OproznijOdkurzacz(double stan_zapelnienia)
        {
            stan_zapelnienia = 0;
        }
        public void OproznijOdkurzaczREF(ref double stan_zapelnienia)
        {
            stan_zapelnienia = 0;
        }


        public void ZmienProducenta(out string producent, out bool czy_kabel)
        {
            Console.Write("\nPodaj nowego producenta: ");
            producent = Console.ReadLine();
            this.producent = producent;

            string odp;
            do
            {
                Console.Write("\nCzy odkurzacz ma byc przewodowy: ");
                odp = Console.ReadLine();
            } while (odp != "tak" && odp != "nie");

            if (odp == "tak")
            {
                czy_kabel = true;
            }
            else
            {
                czy_kabel = false;
            }
            this.przewodowy = czy_kabel;
        }

        public void PrzywrocZKopii(Odkurzacz kopia)
        {
            this.producent = kopia.producent;
            this.przewodowy = kopia.przewodowy;
            this.pojemnosc = kopia.pojemnosc;
            this.zapelnienie = kopia.zapelnienie;
        }

    }
}
