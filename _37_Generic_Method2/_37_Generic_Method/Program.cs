namespace Generic;

class Program
{
   

    //Generic Type --- Genelde T Olarak Kısaltılır
    static void YazdirGeneric<T>(T deger)
    {
        Console.WriteLine($"Generic Method {deger}");
    }
    static void Degistir<T>(ref T x, ref T y)
    {
        T Gecici = x;
        x = y;
        y= Gecici;
    }

    static void Main(string[] args)
    {
        string isim= "Hakan", soyisim = "Özkaya";
        int x=10, y=15;
        Console.WriteLine(x + " " + y);
        Degistir<int>(ref x, ref y);// Burada < > Arasında Bulunan değişken methodtaki <T>  Yerine Geçiyor
        Console.WriteLine(x + " " + y);
        Console.WriteLine(isim + " " + soyisim);
        Degistir<string>(ref isim, ref soyisim);
        Console.WriteLine(isim + " " + soyisim);
    }
}