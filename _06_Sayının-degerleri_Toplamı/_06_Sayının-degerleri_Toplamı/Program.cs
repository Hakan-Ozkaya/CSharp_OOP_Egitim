namespace DegerlerToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Giriniz : ");

            int sayi =Convert.ToInt32(Console.ReadLine());


            int toplam = 0;
            foreach (var sayii in sayi.ToString())
            {
                int sayiceviri = int.Parse(sayii.ToString());//Burada Convert.ToInt32 Kullandığımız Zaman Hata Aldık Çünkü String 1 Sayısının ASCII/Unicode değeri 49 imiş bende sonradan öğrendim.
                toplam += sayiceviri;
                
                
            }
            Console.WriteLine(toplam);


            Console.ReadLine();

            //Burada Videoda 4 ile 6 basamak arası yaptı ancak ben her girilen sayı için olmasını istedim ve yukarıdaki kodu yazdım.

            //int birler = sayi % 10;
            //int onlar = (sayi % 100) / 10;
            //int yüzler = (sayi % 1000) / 100;
            //int binler = (sayi % 10000) / 1000;
            //int onbinler = (sayi % 100000) / 1000;
            //int yüzbinler = (sayi % 100000);

            //int sayideğeritoplami = birler + onlar + yüzler + binler + onbinler + yüzbinler;
            //Console.WriteLine("{0} Sayısının Değerleri Toplamı {1}"+ sayi, sayideğeritoplami);





        }
    }
}