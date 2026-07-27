namespace OverLoading
{

    // Aynı Methodun Farklı Parametreler Almış Hali
    class Program
    {
        static void Main(string[] args)
        {
            toplama(5, 6.7);
            Console.ReadLine();
        }
        static void toplama(int x, int y)
        {
            Console.WriteLine("int "+(x+y));
        }
        static void toplama(double x, double y)
        {
            Console.WriteLine("Double "  + (x + y));
        }
    }
}