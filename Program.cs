namespace File
{

    class Program
    {
        public delegate double Converter(double EVR);

        static  double EVR(double EVR)
        {
            return EVR * 12_750;
        }
        static  double USD(double SSS)
        {
            return SSS * 11_545;
        }
        static double RUB(double RUBL)
        {
            return RUBL * 150;
        }
        static double GBP(double GBP)
        {
            return GBP * 15_100;
        }
        static double CHF(double CHF)
        {
            return CHF * 13_250;
        }
        static double AED(double AED)
        {
            return AED * 3_130;
        }
        static void Main(string[] args)
        {
            Converter[] converters = new Converter[6];

            converters[0] = EVR;
            converters[1] = USD;
            converters[2] = RUB;
            converters[3] = GBP;
            converters[4] = CHF;
            converters[5] = AED;

            foreach(var i in  converters)
            {
                Console.WriteLine($"100 UZS -> {i.Method.Name} {i(100)}");
            }
        }
    }
}