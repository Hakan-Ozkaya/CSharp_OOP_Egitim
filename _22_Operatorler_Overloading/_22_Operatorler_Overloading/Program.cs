namespace OpertaorOverloading { 
    class Program
    {   
        class Vektor
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Vektor(int x, int y)
            {
                X = x;
                Y = y;
            }
            public static Vektor operator +(Vektor a, Vektor b)//Buradaki artı işareti vektörleri gönderirken toplama işlemi yapacağımı belirtiyor
                //aşağıda gönderirken + işlemi harici başka bir işlem yapsan hata verir ona da başka bir overloading yapman gerekir

            {
                int YeniVektorx = a.X + b.X;
                int YeniVektory = a.Y + b.Y;
                Vektor c = new Vektor(YeniVektorx, YeniVektory);
                return c;
            }
            public static Vektor operator -(Vektor a, Vektor b)

            {
                int YeniVektorx = a.X - b.X;
                int YeniVektory = a.Y - b.Y;
                Vektor c = new Vektor(YeniVektorx, YeniVektory);
                return c;
            }

        }
        static void Main(string[] args)
        {
            Vektor v1=new Vektor(1, 2);
            Vektor v2=new Vektor(2, 5);
            Vektor v3 = v1 + v2;
            Vektor v4 = v1 - v2;

            Console.WriteLine(v3.X + " " + v3.Y);
            Console.WriteLine(v4.X + " " + v4.Y);

            Console.ReadLine();
       
        }
    }
}