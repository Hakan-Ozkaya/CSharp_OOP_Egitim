// Dictionary de indexof kullanılmıyor indexi öğrenemiyoruz

namespace Dictionary;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> sozluk = new Dictionary<string,int>();
        sozluk.Add("Hakan", 20);
        sozluk.Add("Hakan2", 25);
        sozluk.Add("Hakan3", 30);
        sozluk.Add("Hakan4", 35);

        foreach (var item in sozluk)
        {
            Console.WriteLine(item);
        }
        sozluk.Remove("Hakan2");

        Console.WriteLine("Yeni Sözlük Elemanları");

        foreach (var item in sozluk)
        {
            Console.WriteLine(item);
        }

        foreach (var item in sozluk.Values)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine(sozluk.Count());


        if (sozluk.ContainsKey("Hakan3"))
        {
            Console.WriteLine(sozluk["Hakan3"]);
        }


        sozluk.Clear();
        Console.WriteLine(sozluk.Count());



    }
}