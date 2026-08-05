namespace Generic;
class Program
{
    static void Yazdir(int x)
    {
        Console.WriteLine("int : "+ x);
    }
    static void Yazdir(double x)
    {
        Console.WriteLine("double : " + x);
    }
    static void Yazdir(string x)
    {
        Console.WriteLine("string : " + x);
    }
    static void Yazdir(bool x)
    {
        Console.WriteLine("bool : " + x);
    }
    
    //Generic Type --- Genelde T Olarak Kısaltılır
    static void YazdirGeneric<T>(T deger)
    {
        Console.WriteLine($"Generic Method {deger}");
    }
    
    static void Main(string[] args)
    {
        Yazdir(true);
        YazdirGeneric<int>(5);
        YazdirGeneric<double>(5.4);
        YazdirGeneric<string>("Hakan");
        YazdirGeneric<bool>(true);
    }
}