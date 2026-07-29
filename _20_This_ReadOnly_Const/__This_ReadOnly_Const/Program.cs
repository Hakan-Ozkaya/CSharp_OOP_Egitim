using Ders_20;

// Readonly constuctor içerisinden değiştirilebilir
// Readonly sabit değeri Sonradan değişken atanabilir
// Consot sabiti tanımlandığında değer ataması yapılmalıdır
// Readonly de matemtiksel işlemlerin sonucunu alabiliyor ancak const alamaz 

namespace Ders_20
{
    class Isci
    {
        private static readonly string mesaj = "Hakan Özkaya Static Deneme";
        public static void  MesajYaz()
        {
            Console.WriteLine( mesaj);
        }
       

        
        static readonly string slogan = "İşçilik Önemlidir";
        public readonly double maas;
        public const double PI = 3.4;
        public Isci(double maas)
        {
            this.maas = maas;
        }
        readonly double muta = Math.Abs(-2);
        //const double mutb = Math.Abs(-5); burada kullanamıyoruz Const ise olmuyor
        public void Slogansoyle()
        {
            Console.WriteLine(slogan);
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             
            Isci i1 = new Isci(1250);
            Isci i2 = new Isci(2000);
            i1.Slogansoyle();
            Isci.MesajYaz();
            
            
            



            Console.WriteLine(i1.maas + "  " + i2.maas);


        }
    }
}
