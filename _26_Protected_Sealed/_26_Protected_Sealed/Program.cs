
// Protected -- Korunmuş   ===== Saled --Korunmuş/Gizli/Kapalı

namespace Protected_Sealed;
class Program
{
    /* sealed */ class Kisiler // Base Class --- Ana Sınıf  --------- Sealed Kullanımı Da Bu Şekilde
    {
        protected string isim {  get; set; }
    }
    class Ogrenci:Kisiler // Derived Class --- Türemiş Sınıf
    {
        public Ogrenci(string i)
        {
            isim = i;
        }
        public string isimsoyle()
        {
            return isim;
        }
    }
    static void Main(string[] args)
    {
        Ogrenci o1 = new Ogrenci("Hakan");
        Console.WriteLine(o1.isimsoyle());


    }
}