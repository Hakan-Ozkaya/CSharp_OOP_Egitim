namespace abstractornek;
class Program
{
    //abstract -- soyut anlamında    abstract tanımlanan her bir method override edilmelidir.
    abstract class Sekil
    {
        public abstract void sekilciz();
    }
    class Dikdortgen : Sekil
    {
        public override void sekilciz()
        {
            Console.WriteLine("Dikdörtgen Çiziliyor.");
        }
    }
    static void Main(string[] args)
    {

    }
}