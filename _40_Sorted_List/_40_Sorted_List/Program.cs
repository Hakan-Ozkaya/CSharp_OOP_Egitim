//Aynı Anahtar Kullanırsak hata alırız keys bir nevi id'dir.
//Sorted List Otomatik Olarak Alfabeye Ve Büyükten Küçüğe Sıralar

namespace Sorted_List;
class Program
{
    static void Main(string[] args)
    {
        SortedList<string, int> siraliliste=new SortedList<string, int>();
        siraliliste.Add("Hakan", 20);
        siraliliste.Add("Özkaya", 25);
        siraliliste.Add("Özkaya2", 253);
        siraliliste.Add("Özkaya3", 252);
        siraliliste.Add("Özkaya4", 251);



        foreach (var itemKey in siraliliste.Keys)//.Keys İle anahtarların içerisine girdik burada 
        {
            Console.WriteLine(itemKey+" "+ siraliliste[itemKey]);//item.Key İle string değerlerine ulaşabiliyoruz Value İle De int değerlerine ulaştık
        }
        Console.WriteLine(" Eleman Sayısı" + siraliliste.Count);


        siraliliste.Remove("Hakan");//string değer alıyor bu da anathar oluyor.

        foreach (var itemKey in siraliliste.Keys)//.Keys İle anahtarların içerisine girdik burada 
        {
            Console.WriteLine(itemKey + " " + siraliliste[itemKey]);//item.Key İle string değerlerine ulaşabiliyoruz Value İle De int değerlerine ulaştık
        }
        Console.WriteLine(" Eleman Sayısı"+ siraliliste.Count);


        foreach (var item in siraliliste.Values)
        {
            Console.WriteLine(item);
            
        }
        
        Console.WriteLine(" İndex Numarası : " + siraliliste.IndexOfKey("Özkaya"));//Böyle De İndex Numarasını Öğreniyoruz

        
        //Console.WriteLine(siraliliste["Özkaya2"]);// Sortd List te [] içerisinde 0 vs girilmez Keys Girmen Gerekir
        if (siraliliste.ContainsKey("Özkaya2"))
        {
            Console.WriteLine(siraliliste.IndexOfKey("Özkaya2"));
        }
        if (siraliliste.ContainsValue(252))
        {
            Console.WriteLine(siraliliste.IndexOfValue(252));
        }



    }
}