namespace Feild_and_Propery
{
    class Program
    {
        static void Main(string[] args)
        {
            insan i1=new insan("Erkek");
            i1.Isim = "Hakan Özkaya";
            i1.Yas = 23;
            i1.Boy = 125;///Alt Satırda Buradan Bahsediyorum
            Console.WriteLine(i1.Isim+" "+i1.Yas+" "+i1.Cinsiyet/*i1.Boy*//*  Burada İ1.Boy Propertysi Private Get Methodu İle Kullanıldığı için Çağırılamıyor Ancak üstteki gibi değiştirilebiliyor*/);

              
        }
    }
    class insan
    {
        private string isim; //Feild -- Alan
        private int yas;//Feild -- Alan
        public string Isim // Property -- Mülk 
        {
            get { return isim; } // Almak
            set { isim = value; } // Kurmak   Valur-- Dışarıdan Gönderdiğimiz Değer Anlamında
        }
        public int Yas // Propery --- Mülk
        {
            get { return yas; }
            set { this.yas = value; }
        }

        public string Cinsiyet { get; }//"Read- Only" Burada Set Kapalı Yani Cinsiyet Sadece Bir Kere Tanımlanır Ve Bir Daha Değiştirilmek istenirse Set Methodunu Kullanmadığımız İçin Değiştiremeyiz.
        public int Boy { private get; set; }//Write-Only
        public insan(string cinsiyet)
        {
            this.Cinsiyet= cinsiyet;
        }

    }
}