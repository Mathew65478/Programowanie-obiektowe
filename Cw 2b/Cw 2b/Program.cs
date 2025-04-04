namespace Cw_2b
{
    internal class Program
    {
        class sortowanie
        {
            private int[] tablica = new int[10];
            public void read_data()
            {
                Console.WriteLine("Podaj Liczby do posortowania");

                for (int i = 0; i < tablica.Length; i++) 
                {
                    Console.Write($"Podaj liczbe {i + 1}.:");
                    tablica[i] = int.Parse(Console.ReadLine());
                }

            }

            public void process_data() 
            { 
                for (int i = 0; i < tablica.Length - 1; i++) 
                {
                    for (int j = 0; j < tablica.Length - i - 1; j++)
                    {
                        if (tablica[j] > tablica[j + 1])
                        {
                            int temp = tablica[j];

                            tablica[j] = tablica[j + 1];

                            tablica[j + 1] = temp;
                        }
                    }
                }

            }

            public void show_results()
            {
                Console.WriteLine("\nPosortowane liczby:");
                foreach (int liczby in tablica)
                {
                    Console.Write(liczby + " ");
                }
                Console.WriteLine();

            }


        }
        static void Main(string[] args)
        {
            sortowanie sort = new sortowanie();

            sort.read_data();
            sort.process_data();
            sort.show_results();

        }
    }
}
