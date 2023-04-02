namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wybor, wybor_co;
            bool x;
            Console.WriteLine("Czym chcesz się zająć?");
            Console.WriteLine("1. Odkurzacz");
            Console.WriteLine("2. Lodowka");
            do
            {
                Console.Write("Wybór: ");
                x = Int32.TryParse(Console.ReadLine(), out wybor_co);
            } while (wybor_co < 1 || wybor_co > 3 || x == false);

            if (wybor_co == 1)
            {
                Console.WriteLine("Podaj: ");
                Console.Write("\nNazwe producenta: ");
                string nazwa_producenta = Console.ReadLine();

                string odp;
                do
                {
                    Console.Write("\nCzy odkurzacz jest przewodowy:");
                    odp = Console.ReadLine();
                } while (odp != "tak" && odp != "nie");

                bool czy_przewodowy;
                if (odp == "tak")
                {
                    czy_przewodowy = true;
                }
                else
                {
                    czy_przewodowy = false;
                }

                double pojemnosc;
                do
                {
                    Console.Write("\nPodaj pojemnosc odkurzacza w litrach: ");
                    x = double.TryParse(Console.ReadLine(), out pojemnosc);
                } while (x == false || pojemnosc < 0);

                double zapelnienie;
                do
                {
                    Console.Write("\nJaki jest % zapełnienia odkurzacza: ");
                    x = double.TryParse(Console.ReadLine(), out zapelnienie);
                } while (x == false || zapelnienie < 0 || zapelnienie > 100);



                Odkurzacz odkurzacz = new Odkurzacz(nazwa_producenta, czy_przewodowy, pojemnosc, zapelnienie);

                Odkurzacz odkurzacz_kopia = new Odkurzacz(odkurzacz);

                do
                {
                    Console.Clear();

                    Console.WriteLine("\n=============================================");
                    Console.WriteLine("Odkurzacz:");
                    Console.WriteLine("=============================================\n");
                    odkurzacz.Wypisz();
                    Console.WriteLine("\n=============================================");
                    Console.WriteLine("Odkurzacz kopia:");
                    Console.WriteLine("=============================================\n");
                    odkurzacz_kopia.Wypisz();
                    Console.WriteLine("\n=============================================\n");

                    Console.WriteLine("\nCo chcesz zrobić?: ");
                    Console.WriteLine("1. Opróżnij odkurzacz (wartość)");
                    Console.WriteLine("2. Opróżnij odkurzacz (REF)");
                    Console.WriteLine("3. Zmien producenta OUT");
                    Console.WriteLine("4. Przywróć z kopii");
                    Console.WriteLine("5. Super Odkurzcz");
                    Console.WriteLine("6. Co zużywa więcej prądu?");
                    Console.WriteLine("7. Wyjdz");


                    do
                    {
                        Console.Write("Wybór: ");
                        x = Int32.TryParse(Console.ReadLine(), out wybor);
                    } while (wybor < 1 || wybor > 7 || x == false);

                    if (wybor == 1)
                    {
                        Console.WriteLine("Przed: " + odkurzacz.Zapelnienie);
                        odkurzacz.OproznijOdkurzacz(zapelnienie);
                        odkurzacz.Zapelnienie = zapelnienie;
                        Console.WriteLine("Po: " + odkurzacz.Zapelnienie);
                        Console.ReadLine();
                    }
                    else if (wybor == 2)
                    {
                        Console.WriteLine("Przed: " + odkurzacz.Zapelnienie);
                        odkurzacz.OproznijOdkurzaczREF(ref zapelnienie);
                        odkurzacz.Zapelnienie = zapelnienie;
                        Console.WriteLine("Po: " + odkurzacz.Zapelnienie);
                        Console.ReadLine();
                    }
                    else if (wybor == 3)
                    {
                        odkurzacz.ZmienProducenta(out string nazwa, out bool czy_kabel);
                        Console.WriteLine("Wartość wysłanej zmiennej nazwy po wyjściu z funkcji: " + nazwa);
                        Console.WriteLine("Wartość wysłanej zmiennej przewodu po wyjściu z funkcji: " + czy_kabel);
                        Console.ReadLine();
                    }
                    else if (wybor == 4)
                    {
                        odkurzacz.PrzywrocZKopii(odkurzacz_kopia);
                    }else if(wybor == 5)
                    {
                        Odkurzacz superOdkurzacz = odkurzacz + odkurzacz_kopia;
                        superOdkurzacz.Wypisz();
                        Console.ReadLine();
                    }else if(wybor == 6)
                    {
                        bool zuzycie = odkurzacz > odkurzacz_kopia;
                        bool zuzycie2 = odkurzacz < odkurzacz_kopia;
                        if (zuzycie)
                        {
                            Console.WriteLine("Oryginał zużywa więcej");
                        }
                        else if (zuzycie2)
                        {
                            Console.WriteLine("Kopia zużywa więcej");
                        }
                        else
                        {
                            Console.WriteLine("Tyle samo");
                        }
                        Console.ReadLine();


                    }


                } while (wybor != 7);

            }
            else
            {
                Console.WriteLine("Podaj:");
                Console.WriteLine("Nazwe producenta: ");
                string nazwa_producenta = Console.ReadLine();
                int ilosc_polek;
                do
                {
                    Console.Write("Podaj ilosc półek: ");
                    x = Int32.TryParse(Console.ReadLine(), out ilosc_polek);
                } while (x == false || ilosc_polek < 1 || ilosc_polek > 100);


                string odp;
                do
                {
                    Console.WriteLine("Czy jest zamrazara?(tak/nie)");
                    odp = Console.ReadLine();
                } while (odp != "tak" && odp != "nie");
                bool ma_zamrazarke;

                if (odp == "tak")
                {
                    ma_zamrazarke = true;
                }
                else
                {
                    ma_zamrazarke = false;
                }



                double temperatura;

                do
                {
                    Console.WriteLine("Podaj temperature lodówki: ");
                    x = double.TryParse(Console.ReadLine(), out temperatura);
                } while (x == false || temperatura < 0);


                Lodowka lodowka = new Lodowka(nazwa_producenta, ilosc_polek, ma_zamrazarke, temperatura);

                Lodowka lodowka_kopia = new Lodowka(lodowka);





                do
                {
                    Console.Clear();
                    Console.WriteLine("\n=============================================");
                    Lodowka.WyswietlLiczbeInstacji();
                    Console.WriteLine("\n=============================================");
                    Console.WriteLine("\n=============================================");
                    Console.WriteLine("Lodowka:");
                    Console.WriteLine("=============================================\n");
                    lodowka.Wypisz();
                    Console.WriteLine("\n=============================================");
                    Console.WriteLine("Lodowka kopia:");
                    Console.WriteLine("=============================================\n");
                    lodowka_kopia.Wypisz();
                    Console.WriteLine("\n=============================================\n");


                    Console.WriteLine("\nCo chcesz zrobić?: ");
                    Console.WriteLine("1. Zwieksz x2 temperature lodówki (REF)");
                    Console.WriteLine("2. Zwieksz x2 temperature lodówki (wartość)");
                    Console.WriteLine("3. Zmien ilość półek OUT");
                    Console.WriteLine("4. Przywróć z kopii");
                    Console.WriteLine("5. Fuzja lodówek");
                    Console.WriteLine("6. Co zużywa więcej prądu?");
                    Console.WriteLine("7. Wyjdz");

                    do
                    {
                        Console.WriteLine("Wybór: ");
                        x = Int32.TryParse(Console.ReadLine(), out wybor);
                    } while (wybor < 1 || wybor > 7 || x == false);

                    if (wybor == 1)
                    {
                        Console.WriteLine("Przed: " + temperatura);
                        lodowka.ZmienWartoscREF(ref temperatura);
                        lodowka.Temperatura = temperatura;
                        Console.WriteLine("Po: " + temperatura);

                        Console.ReadLine();
                    }
                    else if (wybor == 2)
                    {
                        Console.WriteLine("Przed: " + temperatura);
                        lodowka.ZmienWartosc(temperatura);
                        lodowka.Temperatura = temperatura;
                        Console.WriteLine("Po: " + temperatura);

                        Console.ReadLine();
                    }
                    else if (wybor == 3)
                    {
                        int nowa_wartosc;
                        //Console.WriteLine("Ilosc półek przed: " + lodowka.ilosc_polek);
                        lodowka.ZmienIloscPolek(out nowa_wartosc);
                        Console.WriteLine("Wartość zmiennej po wykonaniu fuknkcji: " + nowa_wartosc);
                        //Console.WriteLine("Ilosc półek po: " + lodowka.ilosc_polek);

                        Console.ReadLine();
                    }
                    else if (wybor == 4)
                    {
                        lodowka.PrzywrocZKopii(lodowka_kopia);
                    }
                    else if(wybor == 5)
                    {
                        Lodowka superLodowka = lodowka + lodowka_kopia;
                        Console.WriteLine("Średnia temperatura dla obu lodówek: " + superLodowka.Temperatura);
                        Console.WriteLine("Sumaryczna ilość pułek do zagospodarowania to: " + superLodowka.Ilosc_polek);
                        Console.ReadLine();
                    }else if(wybor == 6)
                    {
                        bool czy_lepsze = lodowka > lodowka_kopia;
                        bool czy_lepsze2 = lodowka < lodowka_kopia;
                        if(czy_lepsze == true)
                        {
                            Console.WriteLine("Oryginał zużywa więcej");
                        }else if(czy_lepsze2 == true)
                        {
                            Console.WriteLine("Kopia zużywa więcej");
                        }
                        else
                        {
                            Console.WriteLine("Tyle samo");
                        }
                        Console.ReadLine();

                    }

                } while (wybor != 7);
            }
        }
    }
}