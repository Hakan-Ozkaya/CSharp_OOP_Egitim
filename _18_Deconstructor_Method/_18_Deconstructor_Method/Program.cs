
//Deconstuctor -- Yıkıcı Method

namespace Deconstuctor
{
    class Insan
    {
        public Insan()
        {
            Console.WriteLine("İnsan Oluşturuldu");
        }
        ~Insan() 
        {
            Console.WriteLine("Obje Yok Oldu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ObjeOlustur();
            
            GC.Collect();// Burada Silme İşlemi Başlıyor Kullanılmayan Nesneleri Bul Diyorsun
            GC.WaitForPendingFinalizers();//Destructor'ı çalışmayı bekleyen tüm nesneler bitene kadar program burada beklesin

        }
        static void ObjeOlustur()
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
        }
    }
}