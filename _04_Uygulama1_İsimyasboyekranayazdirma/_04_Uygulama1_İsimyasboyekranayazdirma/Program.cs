//Bu Uygulamada Kullancıdan İsim, Boy ve Yaş Değişkenlerini Alıp Ekrana Yazdıracağız.

//Bu Programda Sadece Yazdırma İşlemi Vs Yapılıyordu Ancak Ben Hata Yönetimini tekrar etmek istediğim için biraz oynadım üzerinde Hata Kontrol Açıklamaları Önemsemeseniz De Olur.


namespace MyNamespace
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("İsminizi Yazınız : ");
                string isim = Console.ReadLine();
                HataKontrolisim(isim);//Hata Kontrol İsim
                Console.Write("Yaşınızı Yazınız : ");
                string yas=Console.ReadLine();
                HataKontrolyas(yas);//Hata Kontrol Yaş
                Console.Write("Boyunuzu Yazınız (CM Cinsinden) : ");
                string boy =(Console.ReadLine());
                HataKontrolboy(boy);//Hata Kontorl Boy
                Console.WriteLine($"{isim} isimli kişinin yaşı {yas} ve boyu ise {boy}cm dir");

            }
            catch (Exception ex) { 
                Console.WriteLine (ex.Message);
            
            }
            

            
            Console.ReadLine();
            
        }
        static void HataKontrolyas(string yas)
        {
            
            
            if (!yas.Any(char.IsDigit))
            {
                throw new Exception("Yaş Harf İçeremez");
            }
        }
        static void HataKontrolboy(string boy)
        {

            if (!boy.Any(char.IsDigit))
            {
                throw new Exception("Boy Harf İçeremez");
            }
           
        }
        static void HataKontrolisim(string isim)
        {
            for (int i = 0; i < isim.Length; i++)
            {

                if (isim.Any(char.IsDigit))
                {
                    throw new Exception("İsim Rakam İçeremez");
                }
            }

        }
    }
}