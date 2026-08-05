namespace Hashset;
class Program
{
    static void Main(string[] args)
    {
        HashSet<int> sayilar1=new HashSet<int>();
        HashSet<int> sayilar2 = new HashSet<int>();

        sayilar1.Add(5);// İki defa aynı değeri versem bir defa gösterir
        sayilar1.Add(15);
        sayilar1.Add(7);
        sayilar1.Add(9);
        sayilar1.Add(154);
        sayilar1.Add(1144);


        sayilar2.Add(5);
        sayilar2.Add(15);
        sayilar2.Add(7);
        sayilar2.Add(9);
        sayilar2.Add(11);
        


        Console.WriteLine(sayilar1.IsSubsetOf(sayilar2));// Alt Küme Sorgulama
        Console.WriteLine(sayilar1.IsSupersetOf(sayilar2));// Üst Küme Sorgulama
        Console.WriteLine("--------------------------");



        //sayilar2.IntersectWith(sayilar1);// Burada sayilar2 Hashsetini sayilar1 ve sayilar2 deki HashSet indeki kesişimlerini Sayilar2 HashSetine Attı

        //foreach (var item in sayilar2)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--------------------------");




        //sayilar2.UnionWith(sayilar1);//Burada Birleşimlerini Bulduk İkisi Birleşti Aynı Olanlar Tek Kaldı Sayilar1 deki aynı olanları aldı ve sayilar1 deki farklı olanları aldı
        //foreach (var item in sayilar2)
        //{
        //    Console.WriteLine(item);
        //}



        //Console.WriteLine("--------------------------");
        //sayilar2.ExceptWith(sayilar1);//Burada Farklılıklarını Bulduk
        //foreach (var item in sayilar2)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--------------------------");



        // Örnek -----------------------------
        HashSet<int> sayilarTek = new HashSet<int>();
        HashSet<int> sayilarCift = new HashSet<int>();
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                sayilarCift.Add(i);
            }
            else
            {
                sayilarTek.Add(i);
            }
        }
        HashSet<int> sayilar=new HashSet<int>();

            Console.WriteLine("Tek Sayılar : ");

        foreach (var item in sayilarTek)
        {
            Console.WriteLine(item);

        }
        Console.WriteLine("Çift Sayılar : ");

        foreach (var item in sayilarCift)
        {
            Console.WriteLine(item);

        }
        sayilar.UnionWith(sayilarTek);
        sayilar.UnionWith(sayilarCift);
        Console.WriteLine("Tüm Sayılar");
        


        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }





    }
}