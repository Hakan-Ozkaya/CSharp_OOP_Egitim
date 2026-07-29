namespace Overloading_ornek;
class Program
{
    class Dikdortgen
    {
        public int En { get; set; }
        public int Boy { get; set; }

        public Dikdortgen(int  x, int y)
        {
            En = x;
            Boy = y;
            
            
        }
       
        public static bool operator < (Dikdortgen d1, Dikdortgen d2)
        {
           

            if (d1.En*d1.Boy < d2.En*d2.Boy)
            {
                return true ;
            }
           
            else
            {
                return false;
            }

        }
        public static bool operator >(Dikdortgen d1, Dikdortgen d2)
        {


            if (d1.En * d1.Boy > d2.En * d2.Boy)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        


        
    }
    static void Main(string[] args)
    {
        Console.Write("1. Dikdörtgen İçin En : ");
        int x1=Convert.ToInt32(Console.ReadLine());
        Console.Write("1. Dikdörtgen İçin Boy : ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. Dikdörtgen İçin En : ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. Dikdörtgen İçin Boy : ");
        int y2 = Convert.ToInt32(Console.ReadLine());


        Dikdortgen d1 = new Dikdortgen(x1, y1);
        Dikdortgen d2 = new Dikdortgen(x2, y2);
        
        bool karsilastir = d1 < d2;
        Console.WriteLine(karsilastir);


        

    }
}