using System.Text;
namespace _03_Kullaici_Girdi
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input= Kullanıcı Girişi Ya Da Kullanıcı Giridisi
            
            
            Console.WriteLine("Hakan Özkaya");
            
            
            // string Alma   Console.ReadLine();
           
            
            //char Alma      Console.ReadKey().KeyChar;
            
            
            //int   int.Parse     -  Convert.ToInt32   - İnt. TryParse

            //var output =Kullanıcı Çıktısı
            
            
            /* char kurulumismi;
             Console.Write("Kuruluş İsmi Gİriniz");
             kurulumismi = Console.ReadKey().KeyChar;//Char ile Sadece Bir Harf Aldık Bu Sayede Harf Tuşladığı an ReadLine Ögesinin İşlemi Bitiyor.

             Console.WriteLine($"Girdiğiniz Kuruluş İsmi : {kurulumismi}");
             Console.ReadLine();
            */

            Console.Write("Karesini Almak İstediğiniz Sayıyı Giriniz : ");


            /*int sayi=Convert.ToInt32(Console.ReadLine());//Convert.ToInt32 
            Console.WriteLine("Sayını Karesi = "+ (sayi*sayi));*/



            /* int sayi2=int.Parse(Console.ReadLine());//int.Parse  */



            /*
            string sayigirdi=Console.ReadLine();
            int sayi;
            int.TryParse(sayigirdi, out sayi);
            
            Console.WriteLine("Sayını Karesi = "+ (sayi*sayi)); 

            */

            // double sayi = Convert.ToDouble(Console.ReadLine());
            float sayi=(float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayını Karesi = " + (sayi * sayi)); //Float ile kesirli sayıların karesini hesapladık diğerlerinde Değişken Tiplarınde olmuyor

            Console.ReadLine();

        }
    }
}