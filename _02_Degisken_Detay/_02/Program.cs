using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char karakter = 'k';
            string isim = "Hakan";
            int tamsayi = 15;
            float kesirsayi=3.4f;
            double buyukkesirsayi = 4.5;
            bool anahtar = true;

            Console.Write("Değişkenlerimizin Değeri \n"+ karakter +" "+ isim+" "
                + tamsayi+" " + kesirsayi+" " + buyukkesirsayi+" "+ anahtar+"\n");

            Console.WriteLine("sayi={0} isim={1}", tamsayi, isim);

            int buyukkesirsayininboyutu = Marshal.SizeOf(buyukkesirsayi);
            int kesirlisayininboyutu = Marshal.SizeOf(kesirsayi);
            int tamsayininboyutu = Marshal.SizeOf(tamsayi);
            int isimboyutu = System.Text.ASCIIEncoding.Unicode.GetByteCount(isim);//String Değerin Kaç Byte Yer Kapladığı

            Console.WriteLine(buyukkesirsayininboyutu + " " + kesirlisayininboyutu + " " + tamsayininboyutu
                + " " + isimboyutu+ " Bunlar O Değişkenlerin Kaç Byte Olduğunu Gösteriyor");
            Console.ReadLine();

        }
    }
}
