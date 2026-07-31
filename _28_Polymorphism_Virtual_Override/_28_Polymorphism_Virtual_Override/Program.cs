//Polymorphism Birden Fazla Forum Oluşturma Durumu

namespace Polymorphism_Virtual_Override;
class Program
{
    class Sekil
    {
        //virtual -- Sanal
        public virtual void sekilciz()
        {
            Console.WriteLine("Şekil Çiziliyor");
        }
    }
    class Dikdortgen:Sekil
    {
        //Override -- Geçersiz Kılmak Anlamında Alttaki base.sekilciz(); methodunu geçersiz kılıp kendi çıktımızı yazıyoruz.
        public override void sekilciz()
        {
            //base.sekilciz(); Burada Kendi ana clasında bulunan methodu çağırıyor biz bunun yerine başka bir çıktı vericez.
            Console.WriteLine("Dikdörtgen Çiziliyor");
        }
    }
    class Cember:Sekil
    {
        public override void sekilciz()
        {
            base.sekilciz();//Burada Da base.sekilciz(); ne işe yarıyor gürüyoruz çember yazmıyor ana clasındaki kodu çalıştırıyor
            //Console.WriteLine("Çember Çiziliyor.");
        }
    }
    static void Main(string[] args)
    {
        Dikdortgen d1= new Dikdortgen();
        Cember c1= new Cember();
        d1.sekilciz();
        c1.sekilciz();
    }
}