// Enum Sabit ve değişmeyecek değerleri gruplandırmak için kullanılır.

namespace Enums;
class Program
{
    enum Günler {Pazartesi=1,Salı,Çarşamba=6,Perşembe,Cuma,Cumartesi,Pazar };// = işareti ile de index numarasını belirleyebiliriz. sıradaki index ise 1 artarak numra alımaya devam eder.

    enum TrafikIsiklari { Kırmızı, Sarı, Yeşil}
    static void Main(string[] args)
    {
        Console.WriteLine((int)Günler.Pazartesi);
        Console.WriteLine((int)Günler.Çarşamba);
        Console.WriteLine((int)Günler.Perşembe);

        Console.Write("Hangi Işık Yansın  /n 1-Kırmızı \n2-Sarı \n3-Yeşil  ----  :  ");
        int durum= Convert.ToInt32(Console.ReadLine());

        switch (durum)
        {
            case 1: Console.WriteLine(TrafikIsiklari.Kırmızı+ " Yandı..");
                break;
            case 2: Console.WriteLine(TrafikIsiklari.Sarı + " Yandı..");
                break;
            case 3: Console.WriteLine(TrafikIsiklari.Yeşil + " Yandı..");
                break;
            default: Console.WriteLine("1 İle 3 Arasında Bir Değer Giriniz.");
                break;
        }
    }
}