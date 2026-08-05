//Genelerde Nerede Kullanılır  -- Stack -- Quene -- List

namespace Generic;

class Program
{
 

    //Generic Class -- Genelleştirilmiş Sınıf
   
    // 10 tane eleman olan dizi ... // string int double bilmiyorum

    class Dizi<T>
    {
        int index = 0;
        T[] sayilar = new T[10];
        public void ElemanEkle(T eleman)
        {
            sayilar[index++] = eleman;//Sonraki Satırda index++; yazmak yerine bunu yazdık sayilar[index++]

        }
        public T ElemanGoster(int index)
        {
            return sayilar[index];
        }
        public void ElemanlariGoster()
        {

            foreach (var item in sayilar)
            {
                try
                {

                    if ((int) Convert.ChangeType( item,typeof(T) )!= 0)
                    {
                        Console.WriteLine(item);

                    }
                }catch (Exception e) 
                {
                    Console.WriteLine("String Dizisidir.");
                    foreach (var stringitem in sayilar)
                    { 
                        
                        Console.WriteLine(stringitem);
                    }
                    break;
                        
                }
            }
        }
    
    
    }

    static void Main(string[] args)
    {
        Dizi<string> intDizi= new Dizi<string>();
        intDizi.ElemanEkle("Hakan");
        intDizi.ElemanEkle("Murat");
        intDizi.ElemanEkle("Hakan22");
        intDizi.ElemanlariGoster();


    }
}