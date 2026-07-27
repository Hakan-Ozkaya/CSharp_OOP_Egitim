namespace Argümangecis

    //Passing By Valur --- Değer Geçişi
    //Passing By Referance ---- Referans Geçişi 
    //Out  Adres Gönderimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Kuphesapla(out x);//Kuphesapla(ref x); ref almak istendiği zaman böyle kullanılıyor
            Console.WriteLine(x);
            Console.ReadLine();
        }
        /* 
          
            static void Kuphesapla(int sayi)
        {
           Birinci Parametre Gönderiyorsun gönderdiğin zaman x değişkeninde herhangi bir değiklik olmuyor
             
             {
                sayi = sayi * sayi * sayi;
                Console.WriteLine(sayi);
            }


           */


        /* Burada Referans ile aldık kullanımı yukarıda ref ile alındığını gösteriyor bunu kullanınca aldığımız değerin ram'daki konumunu kullanıyoruz ve bu da aldığımız değişkenin değişmesine sebep oluyor
        static void Kuphesapla(ref int sayi)
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);

        }
        */


        // Out Parametresi İle Alınca Kuphesapla ile gönderdiğimiz değer aslında aldığımız değer oluyor aşağıda sayi olarak gönderdiğimiz değer x ile eşitlenmiş oluyor

        static void Kuphesapla(out int sayi)
        {
            sayi = 5;
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);

        }
    }
}
