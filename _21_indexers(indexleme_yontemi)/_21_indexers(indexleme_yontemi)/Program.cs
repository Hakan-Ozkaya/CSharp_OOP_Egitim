
// Bu dersete tanımlanan Futbolcu class içerisine futbolcular dizisi oluşturduk Main bölümünde bunlara atama yaptık ve bu dizi içerisine get ve set methodu ile gönderimi yaptık

namespace Indexleme;
class Program
{
    class Futbolcu
    {
        string[] futbolcular = new string[10];
        public string this[int index]
        {
            get { return futbolcular[index]; }
            set { futbolcular[index] = value; }
        }
    }
    static void Main(string[] args)
    {
        Futbolcu ilkgrup= new Futbolcu();
        ilkgrup[0] = "Hakan";
        ilkgrup[1] = "Hakan1";
        ilkgrup[2] = "Hakan2";
        for (int i = 0; i < 3 ; i++)
        {
            Console.WriteLine(ilkgrup[i]);

        }

    }
}