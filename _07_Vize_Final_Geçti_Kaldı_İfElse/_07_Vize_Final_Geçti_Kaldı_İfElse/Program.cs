namespace Ders_07
{
    class Program
    {
        static void Main(string[] args)

        {
            //50 Ortalama Üstü Geçti
            //50 Ortalama Altı Kaldı
            try
            {

                Console.Write("Vize Giriniz : ");
                string? vize = Console.ReadLine();// ?'ni Uyarı Vermesin diye koydum 
                HataKontrolVize(vize);
                Console.Write("Vize Giriniz : ");
                string? vize2 = Console.ReadLine();
                HataKontrolVize(vize2);
                Console.Write("Final Giriniz : ");
                string? final = Console.ReadLine();
                HataKontrolFinal(final);
                double ortalama = ((Convert.ToDouble(vize)*0.25) + (Convert.ToDouble(vize2))*0.35) + Convert.ToDouble(final)*0.40 / 3;
                if (ortalama >= 85 && ortalama<=100)

                {
                    Console.WriteLine("Geçti 4'Lük Sistemdeki Puanı : AA");
                }
                else if (ortalama >= 70 && ortalama < 85)
                    Console.WriteLine("Geçti 4'Lük Sistemdeki Puanı : AB");
                else if (ortalama >= 55 && ortalama < 70)
                    Console.WriteLine("Geçti 4'Lük Sistemdeki Puanı : BB");
                else if (ortalama >= 40 && ortalama < 55)
                    Console.WriteLine("Geçti 4'Lük Sistemdeki Puanı : BC");
                else if (ortalama >= 25 && ortalama < 40)
                    Console.WriteLine("Geçti 4'Lük Sistemdeki Puanı : CC");
                else if (ortalama <= 25)
                    Console.WriteLine("kALDI 4'Lük Sistemdeki Puanı : FF");
                else
                {
                    Console.WriteLine("Ortalamanız Düzgün Hesaplanamadı Notlarınızı Düzgün Giriniz? ");
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void HataKontrolVize(string vize)
        {
           
            if (vize.Any(char.IsLetter))
            {
                throw new Exception("Vize İçerisinde Harf BUlunmamalıdır.");
            }
            else if (vize == null)
            {
                throw new Exception("Vize Boş Olamaz.");

            }
        }
        static void HataKontrolFinal(string final)
        {
            
            if (final.Any(char.IsLetter))
            {
                throw new Exception("Final İçerisinde Harf BUlunmamalıdır.");
            }
            else if(final== null)
            {
                throw new Exception("Final Boş Olamaz.");

            }
        }
    }
}
