/* Static olan değişkenler buradaki örnek için anlatayım her bir insan için değil de oluşturulan insanların bütünü için kullanılıyor ve bu oluşturulan static değişken i1 için 
 Kullanılamıyor Class Üzerinden kullanılıyor direkt olarak Insan.InsanSayisi Gibi bu örnekte private ile dışarıdan ulaşılamaz hale getirdiğimiz için ek bir method ile yazdırma
 işlemini gerçekleştirdik */


namespace StaticKavramı
{
    class Insan
    {
        private static int InsanSayisi = 0;

        public Insan()
        {
            InsanSayisi++;
        }
        public static int isYazdir()
        {
            return InsanSayisi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1=new Insan();
            Insan i2=new Insan();
            Insan i3=new Insan();
            Console.WriteLine(Insan.isYazdir());
        }
    }

}