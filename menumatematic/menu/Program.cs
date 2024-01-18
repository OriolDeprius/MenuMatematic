namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcio, a, b;

            string opcions = " *************************** \n" +
                             " *      MENU MATEMATIC     * \n" +
                             " *************************** \n" +
                             " * 1. MAXIM                * \n" +
                             " * 2. MCD                  * \n" +
                             " * 3. MCM                  * \n" +
                             " * 4. FACTORIAL            * \n" +
                             " * 5. COMBINATORI          * \n" +
                             " * 6. DIVISOR MAJOR        * \n" +
                             " * 7. ES PRIMER            * \n" +
                             " * 8. N PRIMER PRIMERS     * \n" +
                             " *************************** \n" +
                             " * 0. SORTIR               * \n" +
                             " *************************** \n";

            do
            {
                Console.Clear();
                Console.WriteLine(opcions);
                Console.Write("Introdueix una opció --> ");
                opcio = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcio)
                {
                    case 0:
                        Console.WriteLine("Has decidit tancar el programa.");
                        break;
                    case 1:

                        a = Convert.ToInt32(ValorIntroduit());

                        b = Convert.ToInt32(ValorIntroduit());

                        Console.Clear();

                        Console.WriteLine($"\nEl valor més gran es {Maxim(a, b)}");

                        CompteEnrere();
                        break;
                    case 2:
                        a = Convert.ToInt32(ValorIntroduit());
                        b = Convert.ToInt32(ValorIntroduit());
                        Console.Clear();
                        Console.WriteLine($"\nEl MCD de {a} i {b} es {Mcd(a, b)}.");
                        CompteEnrere();
                        break;
                    case 3:
                        Mcm();
                        break;
                    case 4:
                        Factorial();
                        break;
                    case 5:
                        Combinatori();
                        break;
                    case 6:
                        DivisorMajor();
                        break;
                    case 7:
                        EsPrimer();
                        break;
                    case 8:
                        NprimersPrimers();
                        break;
                }
            }
            while (opcio != 0);

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"\nEl programa es tancara en {i} segons...");
                Thread.Sleep(1000);
            }
        }
        static void CompteEnrere()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"\nTornant al menu principal en {i}...");
                Thread.Sleep(1000);
            }
        }
        static int ValorIntroduit()
        {
            int valor;
            Console.Write("\nIntrodueix un valor --> ");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }
        static int Maxim(int a, int b)
        {
            if (a < b)
            {
                (a, b) = (b, a);
            }
            return a;
        }
        static int Mcd(int num1, int num2)
        {
            int mcd = int.MinValue;
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0 && i > mcd)
                    mcd = i;
            }
            return mcd;
        }
        static void Mcm()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());


        }
        static void Factorial()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        static void Combinatori()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        static void DivisorMajor()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        static void EsPrimer()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        static void NprimersPrimers()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
