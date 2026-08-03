namespace Nasted_Classes;
class Program
{
    class Araba
    {
        public string Model;
        public Motor motor;
        public Araba(string model)
        {
            Model = model;
            motor=new Motor();
            
        }
    }
    class Motor
    {
        public int motorgücü;
    }
    static void Main(string[] args)
    {
        Araba a1 = new Araba("2026");
        a1.motor.motorgücü = 2000;
        Console.WriteLine(a1.Model + " " + a1.motor.motorgücü);
    }
}