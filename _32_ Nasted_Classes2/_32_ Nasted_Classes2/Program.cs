namespace Nasted_Classes2;
class Program
{
    class Insan
    {
        public string isim;
        public int yas;
        El el;
        Kulak kulak;
        Burun burun;
        Goz goz;
        public Insan(string isim,int yas)
        {
            this.isim = isim;
            this.yas = yas;
            el=new El();
            kulak=new Kulak();
            burun=new Burun();
            goz=new Goz();
            Console.WriteLine("İnsan Oluştu");
        }

    }
    class El
    { 
        public El()
        {
            Console.WriteLine("El Oluştu");
        }
    }
    class Kulak
    {
        Uzengi uzengi;
        public Kulak()
        {

            uzengi = new Uzengi();
            Console.WriteLine("Kulak Oluştu");

        }
        class Uzengi
        {
            public Uzengi()
            {
                Console.WriteLine("Üzengi Oluştu");
            }
        }
    }
    class Burun
    {
        public Burun()
        {
            Console.WriteLine("Burun Oluştu");
        }
    }
    class Goz
    {
        public Goz()
        {
            Console.WriteLine("Göz Oluştu");
        }
    }

    static void Main(string[] args)
    {
        Insan i1=new Insan("Hakan",23);
        
        
    }
}