
bool ll = false;
bool wl = false;


wybor(true);



void wybor(bool wl)
{
    bool m = true;
    while (wl)
    {
        Console.WriteLine("1 - potęga");
        Console.WriteLine("2 - pole trójkąta");
        Console.WriteLine("3 - silnia");
        Console.WriteLine("4 - wyjscie");
        int.TryParse(Console.ReadLine(), out int w);
        if (w == 1)
        {
            Console.WriteLine("Podaj liczbę");
            double a = liczba(m);

            Console.WriteLine("Podaj wykładnik potęgi");
            double b = liczba(m);

            Console.Clear();
            Console.Write("potęga wynosi: ");
            Console.WriteLine(Math.Pow(a, b));
        }
        else if (w == 2)
        {
            Console.WriteLine("Podaj bok a");
            double a = liczba(m);

            Console.WriteLine("Podaj bok b");
            double b = liczba(m);

            Console.WriteLine("Podaj bok c");
            double c = liczba(m);

            Console.Clear();
            Console.Write("pole wynosi: ");
            Console.WriteLine(pole(a, b, c));

        }
        else if(w == 3)
        {
            Console.WriteLine("Podaj liczbę");
            double a = liczba(m);

            Console.Clear();
            Console.Write("silnia wynosi: ");
            Console.WriteLine(silnia(a));
        }
        else if(w == 4)
        {
            wl = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("nie możesz tego dać");
        }
    }
    return;
}



double liczba(bool ll)
    
{

    while (ll)
    {
        double.TryParse(Console.ReadLine(), out double l);
        if (l != 0)
        {
            ll = false;
            return l;
        }
        else
        {
            Console.WriteLine("nie możesz tego dać");
        }
    }
    return 0;
}

double pole(double a, double b, double c)
{
    double pp = (a + b + c) / 2;
    double p = Math.Sqrt(pp * (pp-a) * (pp-b) * (pp-c) );

    return p;
}


double silnia(double a)
{
    if (a <= 1)
    {
        return 1;
    }
    else
    {
        return a * silnia(a - 1);
    }
}