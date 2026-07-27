namespace BankaHesap
{
    class Program
    {
        class BankHesap
        {
            private int bakiye;

            public void parayatir(int miktar)
            {
                bakiye += miktar;
            }
            public void paraçek(int miktar)
            {
                bakiye-=miktar;            
            }
            public void BakiyeSorug() 
            {
                Console.WriteLine(bakiye);
            
            }
        }
        static void Main(string[] args) 
        {
            BankHesap b1= new BankHesap();
            b1.parayatir(10);
            b1.BakiyeSorug();
            b1.paraçek(1);
            b1.BakiyeSorug();
        }
    }
}