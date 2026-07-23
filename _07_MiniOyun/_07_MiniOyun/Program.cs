namespace Minioyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int puan = 0, sorusayisi = 0, dogrusayisi = 0, yanlissayisi = 0;

            string devam = "e";
            do
            {
                int ilksayi = rdm.Next(0, 100);
                int ikincisayi = rdm.Next(0, 100);

                Console.WriteLine("İlk Sayı : {0} ------------ ikinci Sayı : {1}", ilksayi, ikincisayi);
                Console.WriteLine("Toplamı Kaçtır? : ");
                int toplam = ilksayi + ikincisayi;
                int sonuc = Convert.ToInt32(Console.ReadLine());

                if (sonuc == toplam)
                {
                    Console.WriteLine("Doğru Cevap");
                    dogrusayisi += 1;
                    puan += 5;
                    sorusayisi += 1;
                    Console.WriteLine("Devam Etmek İstiyor Musunuz?  e/h");
                    devam = Console.ReadLine().ToLower();

                }
                else if (sonuc != toplam)
                {
                    {
                        Console.WriteLine("Yanlış Cevap");
                        yanlissayisi += 1;
                        puan -= 2;
                        sorusayisi += 1;
                        Console.WriteLine("Devam Etmek İstiyor Musunuz?  e/h");

                        devam = Console.ReadLine().ToLower();
                    }


                }


            }
            while (devam == "e");
            {

                Console.WriteLine($" Toplam Soru Sayısı : {sorusayisi}  --------- Doğru Sayınız : {dogrusayisi}  -------- Yanlış Sayını : {yanlissayisi} \n Puanınız : {puan}");
            }

            Console.ReadLine();
            
            
        }
    }
}