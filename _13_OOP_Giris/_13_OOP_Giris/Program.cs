namespace OOP_Giris
{
    class Progar
    {
        static void Main(string[] args)
        {
            insan i1 = new insan();
            i1.İsimsoyisimDuzunele("Hakan", 23);
            Console.WriteLine(i1.isimyasyazdır());
            i1.yurume();

        }
        class insan
        {
            private string isim;
            private int yas;
            public void yurume()
            {
                Console.WriteLine("Yürüyor");
            }
            public void İsimsoyisimDuzunele(string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;

            }
            public string isimyasyazdır()
            {
                return isim + " " + yas;
            }
        }
    }
}