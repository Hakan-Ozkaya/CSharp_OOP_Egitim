namespace Collections_List;
class Program
{
    //List<T> -- İstediğimiz veri tip oluşturabiliriz
    // Listeler Dinamik Bir Yapıya Sahiptir

    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();
        sayilar.Add(1);
        sayilar.Add(8);
        sayilar.Add(-1);
        sayilar.Add(3);
        sayilar.Add(3);
        sayilar.Add(3);
        sayilar.Add(15);
        sayilar.Sort();//string ile yaparsak da alfabetik sıralar

        Console.WriteLine("Lisetenin Eleman Sayısı : "+ sayilar.Count);

        
        sayilar[2] = 125;// Değiştirme

        //for (int i = 0; i < sayilar.Count; i++)
        //{
        //    Console.WriteLine(sayilar[i]);
        //}

        sayilar.RemoveAt(3);// Silime indexe Göre
        sayilar.Remove(3);// Silime veriye Göre aynı veriden fazla varsa en küçük indextekini siler

        //sayilar.Clear();// Tüm Liste Elemanları Silme İşlemi
        sayilar.Insert(3, 235);// Indexe Ekleme İşlemi
        sayilar.Reverse();// Tersten Yazdırma
        if (sayilar.Contains(15))
        {
            sayilar[sayilar.IndexOf(15)] = 15 * 15;
        }

        foreach (var item in sayilar)
        {
            Console.WriteLine(item + " ");
        }



    }
}