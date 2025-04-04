namespace Cw_2a
{

    class prostokat
    {
        private double a;
        private double b;
        private double surface_area;

        public void read_data()
        {
            Console.WriteLine("Podaj długość boku a:");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj długość boku b:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void process_data()
        {
            surface_area = a * b;
        }

        public void show_results()
        {
            Console.WriteLine($"Bok a: {a:F2}");
            Console.WriteLine($"Bok b: {b:F2}");
            Console.WriteLine($"Pole: {surface_area:F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            prostokat rect = new prostokat();

            rect.read_data();
            rect.process_data();

            rect.show_results();
        }
    }
}
