namespace Cw_1c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 wyrazów ciągu Fibonacciego");
            int suma;
            int a = 0;
            int b = 1;

            
            for (int i = 0; i < 10; i++) 
            {
                if (i == 0)
                {
                    Console.WriteLine("F{0} = " + i, i);
                }
                else if (i == 1)
                {
                    Console.WriteLine("F{0} = " + i, i);
                }
                else 
                {
                    suma = a + b;
                    a = b;
                    b = suma;

                    Console.WriteLine("F{0} = " + suma, i);
                }

            }
        }
    }
}
