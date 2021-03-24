using System;

namespace SingletonPattern
{
    internal partial class CoffeMaker
    {
        private static readonly Lazy<CoffeMaker> _singleton = new Lazy<CoffeMaker>(() => new CoffeMaker());

        public static CoffeMaker GetInstance() => _singleton.Value;

        private Status _boiler;

        private CoffeMaker()
        {
            Console.WriteLine("Starting");
            _boiler = Status.Empty;
        }

        public void Fill()
        {
            if (!IsEmpty) return;
            Console.WriteLine("Filling...");
            _boiler = Status.InProgress;
        }

        public void Drain()
        {
            if (!IsBoiled) return;
            Console.WriteLine("Draining...");
            _boiler = Status.Empty;
        }

        public void Boil()
        {
            if (IsBoiled || IsEmpty) return;
            Console.WriteLine("Boiling...");
            _boiler = Status.Boiled;
        }

        private bool IsEmpty => (_boiler == Status.Empty);

        private bool IsBoiled => (_boiler == Status.Boiled);
    }
}
