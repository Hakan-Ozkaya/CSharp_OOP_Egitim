using System.Security.AccessControl;

namespace Ogrenci_Otomasyon;
class Program
{
    static void Main(string[] args)
    {
        DosyaYoksaOlustur();
        Console.WriteLine("Öğrenci Otomasyon Sistemine Hoşgeldiniz... ");
        int secim;
        do
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("1-) Kayıt Ekle");
            Console.WriteLine("2-) Kayıt Güncelle");
            Console.WriteLine("3-) Kayıt Göster");
            Console.WriteLine("4-) Kayıt Sil");
            Console.WriteLine("5-) Not Ortalaması Göster");
            Console.WriteLine("6-) Çıkış");
            secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    KayitEkleme();
                    break;
                case 2:
                    KayitGüncelleme();
                    break;
                case 3:
                    KayitlariGoster();
                    break;
                case 4:
                    KayitSilme();
                    break;
                case 5:
                    NotOrtalamaGoster();
                    break;
                case 6:
                    Console.WriteLine("Program Sonlandı ... ");
                    break;
                default: Console.WriteLine("Lütfen 1-6 Arasında Bir Değer Giriniz."); break;
            }
        }
        while (secim != 6);
        {

        }


    }
    static void DosyaYoksaOlustur()
    {
        if (!File.Exists("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt"))
        {
            File.Create("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt");

        }
    }
    static void KayitEkleme()
    {
        int Id; //identity -- anahtar -- örnek tc herkeste tek olması gerekir //Oto İncrement Otomatik İd Artışı Demek
        string isim;
        int Yas;
        Double MatNot;
        Console.Write("Lütfen Oğrencinin Id Giriniz : ");
        Id = int.Parse(Console.ReadLine());
        Console.Write("Lütfen Oğrencinin İsmini Giriniz : ");
        isim = Console.ReadLine();
        Console.Write("Lütfen Oğrencinin Yaşını Giriniz : ");
        Yas=Convert.ToInt32(Console.ReadLine());
        Console.Write("Lütfen Oğrencinin Notunu Giriniz : ");
        MatNot= Convert.ToDouble(Console.ReadLine());

        File.AppendAllText("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt", Id + " "+ isim+" "+ Yas+ " "+ MatNot+ Environment.NewLine);//Environment.NewLine Dosya İşlemlerinde Alt Satıra Geçme

    }

    static void KayitGüncelleme()
    {
        string[] Ogrenciler = File.ReadAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt");
        Console.WriteLine("Kaydını Güncellemek İstediğiniz Öğrencinin Id'yi Giriniz : ");
        int Degisecek_Id=int.Parse(Console.ReadLine());
        
        int id;
        string isim;
        int yas;
        double not;

        int[] Idler = new int[Ogrenciler.Length];
        string[] isimler = new string[Ogrenciler.Length];
        int[] yaslar = new int[Ogrenciler.Length]; ;
        double[] notlar = new double[Ogrenciler.Length]; ;
        string[] parcaliveri;

        int i = 0;
        foreach (var item in Ogrenciler)
        {
            parcaliveri = item.Split(' ');
            Idler[i] = int.Parse(parcaliveri[0]);
            isimler[i] = parcaliveri[1];
            yaslar[i] = int.Parse(parcaliveri[2]);
            notlar[i] = double.Parse(parcaliveri[3]);
            i++;
        }

        int güncelleneceksatirindex = 0;
        while (true)
        {
            if (Idler[güncelleneceksatirindex] == Degisecek_Id)
            {
                break;
            }
            güncelleneceksatirindex++;
        }
        id = Idler[güncelleneceksatirindex];
        isim = isimler[güncelleneceksatirindex];
        yas = yaslar[güncelleneceksatirindex];
        not = notlar[güncelleneceksatirindex];
        
        int sayac = 0;

       
        
        int Secim;
        Console.Write("Güncellemek İstediğiniz Değer \n 1-) İsim \n 2-) Yaş \n 3-) Not \n 4-)Güncelleme İptal \n Değerlerini Giriniz : ");
        Secim = int.Parse(Console.ReadLine());
        do
        {
            switch (Secim)
            {
                case 1:
                    Console.Write("Yeni İsmi Giriniz : ");
                    isim = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Yeni Yaşı Giriniz : ");
                    yas = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Yeni Notu Giriniz : ");
                    not = Convert.ToDouble(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Güncelleme İptal");
                    break;

                default:
                    {
                        Console.WriteLine("1-4 Arasi Seçim Yapınız");
                        break;

                    }
            } 
        } while (Secim > 4 || Secim < 1);
        
        string yenieklenecekVeri= Degisecek_Id.ToString()+" "+ isim + " "+yas.ToString()+" "+ not.ToString();
        Ogrenciler[güncelleneceksatirindex] = yenieklenecekVeri;
        File.WriteAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt", Ogrenciler);


    }
    static void KayitlariGoster()
    {
        string[] Ogrenciler = File.ReadAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt");
        
        
        int[] Idler=new int[Ogrenciler.Length];
        string[] isimler=new string[Ogrenciler.Length];
        int[] yaslar= new int[Ogrenciler.Length]; ;
        double[] notlar = new double[Ogrenciler.Length]; ;
        string[] parcaliveri;
        int i = 0;
        foreach (var item in Ogrenciler)
        {
            parcaliveri = item.Split(' ');
            Idler[i]=int.Parse(parcaliveri[0]);
            isimler[i] = parcaliveri[1];
            yaslar[i]= int.Parse(parcaliveri[2]);
            notlar[i]=double.Parse(parcaliveri[3]);
            i++;
            

        }
        for(int a = 0; a< Idler.Length; a++)
        {
            Console.WriteLine( Idler[a]+" "+ isimler[a] + " " + yaslar[a] + "  " + notlar[a]);
        }
    }
    static void KayitSilme()
    {
        string[] Ogrenciler = File.ReadAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt");
        int silinecekId;
        Console.WriteLine("Lütfen Silmek İstediğiniz Öğrencinin Id'sini Giriniz.");
        silinecekId=int.Parse(Console.ReadLine());
        




        int[] Idler = new int[Ogrenciler.Length];
        string[] isimler = new string[Ogrenciler.Length];
        int[] yaslar = new int[Ogrenciler.Length]; ;
        double[] notlar = new double[Ogrenciler.Length]; ;
        string[] parcaliveri;

        int i = 0;
        foreach (var item in Ogrenciler)
        {
            parcaliveri = item.Split(' ');
            Idler[i] = int.Parse(parcaliveri[0]);
            isimler[i] = parcaliveri[1];
            yaslar[i] = int.Parse(parcaliveri[2]);
            notlar[i] = double.Parse(parcaliveri[3]);
            i++;
        }
        
        int siliceneceksatirIndex = 0;
        while (true)
        {
            if(Idler[siliceneceksatirIndex] == silinecekId)
            {
                break;
            }
            siliceneceksatirIndex++;
        } 
        string[] yenidosyakayitlari = new string[Ogrenciler.Length-1];
        int sayac = 0;

        for (i = 0; i < Ogrenciler.Length; i++)
        {
            if (i != siliceneceksatirIndex)
            {
                yenidosyakayitlari[sayac] = Ogrenciler[i];
                sayac++;
            }
        }
        File.WriteAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt",yenidosyakayitlari);
       

    }
    static void NotOrtalamaGoster()
    {
        string[] ogrenciler = File.ReadAllLines("D:\\CSharpOOPEgitim\\_35_Ogrenci_Otomasyon\\Ogenci_Bilgileri.txt");
        double not;
        double toplam = 0;
        
        for (int i = 0; i < ogrenciler.Length; i++)
        {

            not= double.Parse(ogrenciler[i].Split(' ')[3]);
            toplam += not;
        }
        Console.WriteLine("Öğrencilerin Not Ortalaması : {0}", toplam / ogrenciler.Length);
    }

}