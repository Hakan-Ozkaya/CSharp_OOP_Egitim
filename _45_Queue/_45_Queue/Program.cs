namespace Queue;
class Program
{
    //Queue -- Kuyruk Yazıcı Mantığı ilk gönderilen ilk çıkar
    static void Main(string[] args)
    {
        Queue<string> Yazici= new Queue<string>();
        Yazici.Enqueue("1. Dosya");
        Yazici.Enqueue("2. Dosya");
        Yazici.Enqueue("3. Dosya");

        string[] ciktilar= Yazici.ToArray();// Diziye Dönüştürdük Burada

        Console.WriteLine(Yazici.Peek()); //Kuyruğun Başındaki Elemanı Gösteriyor İlk Çıkacak Eleman
        

        Console.WriteLine("Kalan Dosya Sayısı : " + Yazici.Count);

        

        foreach (var item in Yazici)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------");
        Yazici.Dequeue();// İlk Dosya Çıktı Kuyruktan
        Yazici.Dequeue();// İkinci Dosya Çıktı Kuyruktan

        foreach (var item in Yazici)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(" Kalan Dosya Sayısı : " + Yazici.Count);
        Yazici.Clear();
        Console.WriteLine("---------------------");

        Console.WriteLine(" Komple Silme İşleminden Sonra Kalan Dosya Sayısı : " + Yazici.Count);

    }
}