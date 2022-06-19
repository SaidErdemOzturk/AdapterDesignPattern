using System;

namespace AdapterCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Sinif1 sinif1 = new Sinif1();
            sinif1.IsYap();
            Adapter adapter = new Adapter();
            adapter.IsYap();
           
        }
    }
    abstract class Abstract
    {
        public abstract void IsYap();
    }
    class Sinif1:Abstract
    {
        public override void IsYap()
        {
            Console.WriteLine("sinif1 deki iş yap çalıştı");
        }
    }
    class Adapter : Abstract
    {
        public override void IsYap()
        {
            Adaptee adaptee = new Adaptee();
            adaptee.BenzerIs();
        }
    }
    class Adaptee
    {
        public void BenzerIs()
        {
            Console.WriteLine("Adaptee sınıfındaki çalıştı");
        }
    }
}
