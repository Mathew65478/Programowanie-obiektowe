using System;
namespace Cw_1b
{
    internal class Program
    {
        static Random rand = new Random();
        static double Liczpi(int n) 
        {
            int punktyokrag = 0;
            for (int i = 0; i < n; i++)
            {
                double x = (rand.NextDouble() * 2) - 1;
                double y = (rand.NextDouble() * 2) - 1;

                double odleglosc = (x * x) + (y * y);

                if (odleglosc <= 1)
                {
                    punktyokrag++;
                } 
            }
            return 4.0 * punktyokrag / n;
        }
        static void Main(string[] args)
        {
            
            int n = 10000; //liczba punktów. Dokładność zwiększa się wraz z ilością  punktów

            var startczas = DateTime.Now;
            double PI = Liczpi(n);
            var koniec = DateTime.Now;

            Console.WriteLine($"Pi: {PI}");
            Console.WriteLine($"Obliczanie zajeło: {(koniec - startczas).TotalSeconds:F5} sekundy");

        }
        
    }

    
}
