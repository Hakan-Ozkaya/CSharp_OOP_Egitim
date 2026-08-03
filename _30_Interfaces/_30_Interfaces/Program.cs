// Interface = Sözleşme.
// Interface'i uygulayan sınıf, içindeki tüm metotları yazmak zorundadır.
// Ortak davranış tanımlamak için kullanılır.

namespace Interfaces;
class Program
{
    abstract class Sekil
    {
        public int yas;
        public string isim {  get; set; }
        public void Deneme()
        {
            Console.WriteLine("Abstract Deneme");
        }
        public abstract void Sekilciz();
    }
    public interface ISekil
    {
        void Sekilciz();
    }
    class Dikdortgen : Sekil ,ISekil
    {
        public override void Sekilciz()
        {
            Console.WriteLine("Şekil Çiziliyor.");
        }
    }
    
    static void Main(string[] args)
    {
        Dikdortgen d1 = new Dikdortgen();
        d1.yas = 23;
        d1.isim = "Hakan";
        d1.Deneme();
        d1.Sekilciz();
        Console.WriteLine(d1.isim+" "+d1.yas);
        
    }
}