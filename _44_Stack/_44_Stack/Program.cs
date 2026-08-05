//Last in first Out  Son Giren İlk Çıkar Mantığı ile Çalışır İndex ile erişemeyiz. 



//  |        |   Stack sistemi bu mantık diyebilirsin ilk en alta ekler sonra üste ilk üstten siler
//  |________|  üste eklre gibi
//  |________|
//  |________|
//  |________|
namespace Stack;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> yigit= new Stack<int>(); // En Alt Kısım 5 15 25 35 10 55 En Üst Kısım
        yigit.Push(5);
        yigit.Push(15);
        yigit.Push(25);
        yigit.Push(35);
        yigit.Push(10);
        yigit.Push(55);

        yigit.Pop();// Yığıttan en üstteki eleman silme
        yigit.Pop(); // Yığıttan en üstteki Yeni eleman silme 

        Console.WriteLine(" Yığın Boyutu : "+yigit.Count);

        if(yigit.Contains(15))
        {
            Console.WriteLine("Sorgulanan Değer : "+15);
        
        }

        foreach (var item in yigit)
        {
            Console.WriteLine(item);
        }




        if (bizimcontains(yigit, 25))
        {
            Console.WriteLine("Eleman Var");
        }
        else
        {
            Console.WriteLine("Eleman Yok");
        }
    }
    static bool bizimcontains(Stack<int> s, int deger)
    {
        foreach (var item in s)
        {
            if (item == deger)
            {
                return true;
            }
      
        }
        return false;

    }
}