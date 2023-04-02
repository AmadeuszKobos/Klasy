using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    internal class Lodowka
    {
        private static int _liczbaInstacji = 0;

        public static void WyswietlLiczbeInstacji()
        {
            Console.WriteLine("Ilość obiektów klasy lodówka: " + _liczbaInstacji);
        }

        public static Lodowka operator +(Lodowka lodowka, Lodowka lodowka_kopia)
        {
            Lodowka lodowka_sum = new Lodowka();
            lodowka_sum.ilosc_polek = lodowka.ilosc_polek + lodowka_kopia.ilosc_polek;
            lodowka_sum.temperatura = lodowka.temperatura + lodowka_kopia.temperatura;
            lodowka_sum.temperatura = lodowka_sum.temperatura/2;
            return lodowka_sum;
        }

        public static bool operator >(Lodowka lodowka, Lodowka lodowka_kopia)
        {
            if(lodowka.zamrazarka == true && lodowka_kopia.zamrazarka == false)
            {
                return true;
            }
            else if(lodowka.zamrazarka == false && lodowka_kopia.zamrazarka == true)
            {
                return false;
            }
            else
            {
                if(lodowka.temperatura < lodowka_kopia.temperatura)
                {
                    return true;
                }
                else if (lodowka.temperatura == lodowka_kopia.temperatura)
                {
                    if (lodowka.ilosc_polek > lodowka_kopia.ilosc_polek)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool operator <(Lodowka lodowka, Lodowka lodowka_kopia)
        {
            if (lodowka.zamrazarka == false && lodowka_kopia.zamrazarka == true)
            {
                return true;
            }
            else if (lodowka.zamrazarka == true && lodowka_kopia.zamrazarka == false)
            {
                return false;
            }
            else
            {
                if (lodowka.temperatura > lodowka_kopia.temperatura)
                {
                    return true;
                }
                else if (lodowka.temperatura == lodowka_kopia.temperatura)
                {
                    if (lodowka.ilosc_polek < lodowka_kopia.ilosc_polek)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
        private int ilosc_polek;
        public int Ilosc_polek
        {
            get { return ilosc_polek; }
            set { ilosc_polek = value; }
        }
        private bool zamrazarka;
        public bool Zamrazarka
        {
            get { return zamrazarka; }
            set { zamrazarka = value; }
        }
        private double temperatura;
        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public Lodowka() 
        {
            _liczbaInstacji++;
        }
        public Lodowka(string nazwa_producenta, int liczba_polek, bool czy_zamrazarka, double gwarancja)
        {
            this.producent = nazwa_producenta;
            this.ilosc_polek = liczba_polek;
            this.zamrazarka = czy_zamrazarka;
            this.temperatura = gwarancja;
            _liczbaInstacji++;
        }

        public Lodowka(Lodowka obiekt)
        {
            this.producent = obiekt.producent;
            this.ilosc_polek = obiekt.ilosc_polek;
            this.zamrazarka = obiekt.zamrazarka;
            this.temperatura = obiekt.temperatura;
            _liczbaInstacji++;
        }


        
        public void Wypisz()
        {
            Console.WriteLine("Producent: " + this.producent);
            Console.WriteLine("Ilosc polek: " + this.ilosc_polek);

            if (zamrazarka == true)
            {
                Console.WriteLine("Lodowka MA zamrazarke");
            }
            else
            {
                Console.WriteLine("Lodowka NIE MA zamrazarki");
            }

            Console.WriteLine("Temperatura: " + this.temperatura);
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
            this.zamrazarka = czy_kabel;
        }

        public void ZmienWartosc(double param)
        {
            param = param * 2;
        }

        public void ZmienWartoscREF(ref double param)
        {
            param = param * 2;
        }

        public void ZmienIloscPolek(out int ilosc_polek)
        {
            bool x;

            do
            {
                Console.Write("Podaj nową liczbe półek: ");
                x = int.TryParse(Console.ReadLine(), out ilosc_polek);
            } while (x == false);
            this.ilosc_polek = ilosc_polek;
        }
        public void PrzywrocZKopii(Lodowka kopia)
        {
            this.producent = kopia.producent;
            this.ilosc_polek = kopia.ilosc_polek;
            this.zamrazarka = kopia.zamrazarka;
            this.temperatura = kopia.temperatura;
        }
    }
}
