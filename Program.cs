using System;

namespace SingletonPattern
{
    static class Program
    {
        static void Main()
        {
            try
            {
                var coffeBeans = CoffeMaker.GetInstance();
                coffeBeans.Fill();
                coffeBeans.Boil();
                coffeBeans.Drain();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}
