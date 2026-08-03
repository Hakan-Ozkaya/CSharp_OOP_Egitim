namespace Structs;
class Program
{
    struct Kitap
    {
        public string yazaradi {  get; set; }
        public string kitapadi;
        public double fiyat;
        public Kitap(string Ka,Double f)
        {
            this.kitapadi = Ka;
            this.fiyat = f;
            this.yazaradi = "null";

        }
    }
    struct Nokta
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    // Class  --  Kalıtım Var  --  Bos Constructor var   -- Büyük Yapılarda Kullanılır Genelde
    // Struct --  Kalıtım Yok  --  Bos Constructor yok   -- Küçük Yapılarda Kullanılır Genelde
    static void Main(string[] args)
    {
        Nokta n1;//   ---
        int x;//          \
        //                  > Bunlar Bir Struct Oluyor
        char y;//         /
        bool b;//     ---
        Kitap k1= new Kitap("Sefiller",20.25);
        Console.WriteLine(k1.yazaradi + " " + k1.kitapadi + " " + k1.fiyat);

    }
}