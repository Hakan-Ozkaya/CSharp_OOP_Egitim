//Parametre Gönderiyoruz Ancak Aynı method ismini kullanıyoruz.

namespace Constuctor_method
{
    class program
    {
        static void Main(string[] args)
        {
            insan i1= new insan();
            insan i2= new insan("Hakan");
            insan i3 = new insan("Hakan" ,25);
        }
    }

    class insan
    {
        public insan()
        {
            Console.WriteLine("Yeni Bir Obje Oluşturuldu");
        }
        public insan(string isim)
        {
            
            Console.WriteLine("Benim Adım " + isim);
        }
        public insan(string isim, int yas)
        {
            Console.WriteLine("Benim Adım {0} Ve Benim Yaşım {1} ", isim, yas);
        }
    }
}