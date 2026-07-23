namespace VarandConst
{
    class Program
    {
        static void Main(string[] args)
        {

            //var ile tanımlanan değişkenlerlerin içerisinde int bir değer varsa o değişken int boolen bir değer var ise değişken bool bir değişken oluyor otomatik atıyor
            //ancak direkt tür belirlemelerde int x; x=5; tarzında iki işlem yapabiliriz sadece tanımlayıp boş bırakabiliriz ancak var da ise direk tanımlamam ve değer atamam gerekiyor.


            /*var x = 5;
            var isim = "Hakan";
            var kesirli = 4.5;
            var anahtar = true;
            var karakter = "h";

            Console.WriteLine(x + isim + kesirli + anahtar + karakter);
            
             */
            //const değişkeni ise sabit olan değerler için kullanılıyor birdaha değiştirilemiyor
            const Double PI = 3.14;

            Console.Write(PI);

            Console.ReadLine();

        }
    }
}