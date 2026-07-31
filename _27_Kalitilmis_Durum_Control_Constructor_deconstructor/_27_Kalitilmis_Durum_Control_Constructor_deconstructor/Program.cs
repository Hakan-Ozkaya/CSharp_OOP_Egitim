//Bu Program Genelde Çalışma Sırasından Bahsediyor İlk Oluşan ve İlk Yok Olan Farklı ÇALIŞMA Mantığı ne onu Anlamamız İçin

using System;

namespace Durum;

class Program
{
    class Calisanlar
    {
        public Calisanlar()
        {
            Console.WriteLine("Calisan Oluştu");
        }
        ~Calisanlar()
        {
            Console.WriteLine("Calisan Yok Oldu");

        }
    }
    class Ogretmen : Calisanlar
    {
        public Ogretmen()
        {
            Console.WriteLine("Öğretmen Oluştu");
        }
        ~Ogretmen()
        {
            Console.WriteLine("Öğretmen Yok Oldu");

        }
    }
    static void Main(string[] args)
    {
        olustur();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.ReadLine();
    }
    static void olustur()
    {
        Ogretmen o1 = new Ogretmen();
       
        

    }
}