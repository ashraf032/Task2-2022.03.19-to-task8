using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci ededi daxil ele");
            string numstr1 = Console.ReadLine();
            Console.WriteLine("ikinci ededi daxil ele");
            string numstr2 = Console.ReadLine();

            if (numstr1.Length+1>=4 && numstr2.Length+1>=7)
            {
                //birinci ededin 4 faizinin tapilmasi
                int numint1 = int.Parse(numstr1);
                double perc4numint1 = numint1 * 0.04;

                //ikinci ededin 9 faizinin tapilmai
                int numint2 = int.Parse(numstr2);
                double perc9numint2 = numint2 * 0.09;

                //Result sum 
                double result = perc4numint1 + perc9numint2;
                Console.WriteLine("-------");

                Console.WriteLine("Netice :");
                Console.WriteLine(result*0.1);

            }
            else
            {
                Console.WriteLine("Xais olunur shertlere uygun eded daxil edin!!!");
            }

        }
    }
}
