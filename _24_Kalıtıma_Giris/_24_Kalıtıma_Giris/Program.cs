//İnheritance -- Kalıtım

namespace Kalıtım;
class Program
{
    class Hayvan
    {
        public int yas { get; set; }

        public string ortakozellik()
        {
            return ("Ortak Özelliklerimiz Var");
        }
    }
    class Kopek:Hayvan 
    {
        public int ayaksayisi;
        public string havla()
        {
            return "Hav Hav";
        }


    }
    class Kedie:Hayvan // Burada Hayvan Clasına Ek başka calasslar tanımlamak da istersek inetface özellik oluyor ilerki derslerde anlatacakmış.
    {
        public string miyavla()
        {
            return "Miyav";
        }


    }
    static void Main(string[] args)
    {
        Kopek k1= new Kopek();
        Kedie kedi1= new Kedie();

        k1.yas = 10;
        k1.ayaksayisi = 4;
        kedi1.yas = 5;
        Console.WriteLine(k1.yas + " " + k1.ayaksayisi + " " + k1.havla()+" "+ k1.ortakozellik());
        Console.WriteLine(kedi1.yas+" "+kedi1.miyavla()+" "+kedi1.ortakozellik());

    }
}