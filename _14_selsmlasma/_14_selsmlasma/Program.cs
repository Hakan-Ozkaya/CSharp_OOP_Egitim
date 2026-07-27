namespace Selamlasma
{
    class Program
    {
        class Insan
        {
            private string isim;
            private int yas;
            public void selamver()
            {
                Console.WriteLine("Merhaba");
            
            }
            public void BilgiSor()
            {
                Console.WriteLine("Adın Ne Ve Yaşın Kaç");
            }
            public void CevapVer()
            {
                Console.WriteLine("Benim Adım {0} ve yaşım {1}",isim,yas);    
            }
            public void IsimveyasDuzenle(string isim,int yas)
            {
                this.isim=isim;
                this.yas=yas;
            }
        }   
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            i1.IsimveyasDuzenle("Hakan", 23);
            i2.IsimveyasDuzenle("Murat", 20);
            i1.selamver();
            i2.selamver();
            i1.BilgiSor();
            i2.CevapVer();
            i2.BilgiSor();
            i1.CevapVer();


        }
    }
}