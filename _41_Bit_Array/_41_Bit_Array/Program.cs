using System.Collections;

namespace Bitarray;
class Program
{


    // 0 0 0 0
    // 1 0 1 1  -- 0 1 0 0
    static void Main(string[] args)
    {
        BitArray ilkDortBit = new BitArray(4);
        BitArray ikinciDortBit = new BitArray(4);
        ilkDortBit[2] = true;
        ikinciDortBit.SetAll(true);


        foreach (var item in ilkDortBit.And(ikinciDortBit)) // Burada And ile 0 1 leri true false olayını yapıyoruz 
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("üst and \n\nalt Or");
        ikinciDortBit[1] = false;
        foreach (var item in ilkDortBit.Or(ikinciDortBit)) // Burada And ile 0 1 leri true false olayını yapıyoruz 
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(" \n Secilen İndex : "+ikinciDortBit.Get(3));
        Console.WriteLine("Length : "+  ikinciDortBit.Length);


        foreach (var item in ilkDortBit.Not())//Değilini Alıyoruz 1 0 Oluyor 0 İse 1
        {
            Console.WriteLine(item);
        }

        //foreach (var item in ilkDortBit)
        //{
        //    Console.WriteLine(item);
        //}

    }
}