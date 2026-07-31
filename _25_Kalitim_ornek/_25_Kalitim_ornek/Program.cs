namespace Ornek;
class Program
{
    class Kisiler
    {
        public string isim {  get; set; }

        public void konus()
        {
            Console.WriteLine("Merhaba");
        }
    }
    class Calisanlar:Kisiler
    {
        public string isyeri {  get; set; }
        public double maas {  get; set; }

        public bool Calisiyormu(int saat)
        {
            if (saat <= 18 && saat >=9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void yazdir()
        {
            Console.WriteLine("Benim Adım : "+  " "+ isim +" Benim Maaşım :  " + maas + "  Çalıştığım Yer : "+ isyeri);
        }

    }
    
    static void Main(string[] args)
    {
        Calisanlar kis = new Calisanlar();
        kis.maas = 10;
        kis.isyeri = "X Şirketi";
        kis.isim = "Hakan";
        if (kis.Calisiyormu(19))
        {
            Console.WriteLine("Çalışıyor");
        }
        else 
        {
            Console.WriteLine("Çalışmıyor"); 
        }
        kis.yazdir();
        Console.ReadLine();
    }
}