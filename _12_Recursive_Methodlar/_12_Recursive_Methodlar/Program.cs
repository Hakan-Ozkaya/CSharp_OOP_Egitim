namespace Recuresive_Methoflar
{
    //Recursive Methodlar Kendi Kendini Çağıran Methoflar Olarak Geçiyor
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(farktoriyel(6));
        }
        static int farktoriyel(int n) 
        
        {
            if (n == 1)
            {
                return 1;
            }
            return n * (farktoriyel(n - 1));
        }
    }
}