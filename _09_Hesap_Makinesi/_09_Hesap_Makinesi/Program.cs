//Hata Yönetimi Üzerine Çalıştığım İçin Biraz Kodlar Üzerine Oynuyorum Kusura Bakmayın

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("İlk Sayıyı Giriniz : ");
                string sayi1 = (Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz : ");
                string sayi2 = (Console.ReadLine());
                Console.WriteLine("İşlem Giriniz + __ - __ * __ / __  % ");
                char islem2 = (Convert.ToChar(Console.ReadLine()));
                double sonuc = 0;
                Sorgu(islem2, sayi1, sayi2);
                double sayi11 = Convert.ToDouble(sayi1);
                double sayi12 = Convert.ToDouble(sayi2);

                if (islem2 == '+')
                {
                    sonuc = sayi11 + sayi12;
                }
                else if (islem2 == '-')
                {
                    sonuc = sayi11 - sayi12;
                }
                else if (islem2 == '*')
                {
                    sonuc = sayi11 * sayi12;
                }
                else if (islem2 == '/') 
                {
                    sonuc = sayi11 - sayi12;
                }
                else if (islem2 == '%')
                {
                    sonuc = sayi11 % sayi12;
                }
                Console.WriteLine("{0} {1}{2} = {3}",sayi1,islem2,sayi2,sonuc);
            }
            catch (Exception e) {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        static void Sorgu(char islem, string sayi1, string sayi2) {
         

            if (islem != '+' && islem != '-' && islem !='*' && islem != '/'&& islem != '%' )
            {
                throw new Exception("Yanlış İşlem Değeri Girdiniz.");
            }
            if (sayi1 == null)
            {
                throw new ArgumentNullException(nameof(sayi1), "Değer null olamaz.");
            }
            if (sayi2 == null)
            {
                throw new ArgumentNullException(nameof(sayi2), "Değer null olamaz.");
            }
            if (!int.TryParse(sayi1, out int sayi))
            {
                throw new FormatException("Lütfen sadece sayısal bir değer giriniz.");
            }
            if (!int.TryParse(sayi2, out int sayi3))
            {
                throw new FormatException("Lütfen sadece sayısal bir değer giriniz.");
            }



        }
    }
}