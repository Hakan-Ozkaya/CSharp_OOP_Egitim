namespace Tekcift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            int sayi= Convert.ToInt32(Console.ReadLine());
            if (sayi % 2== 0)
            {
                Console.WriteLine($"{sayi} Sayısı Çift Bir Sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} Satısı Tek Bir Sayıdır.");
            }
            Console.ReadLine();
        }
    }
}