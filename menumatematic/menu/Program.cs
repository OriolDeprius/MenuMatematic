﻿namespace menu
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
                        a = Convert.ToInt32(ValorIntroduit());
                        b = Convert.ToInt32(ValorIntroduit());
                        Console.Clear();
                        Console.WriteLine($"\nEl MCM de {a} i {b} es {Mcm(a, b)}");
                        CompteEnrere();
                        break;
                    case 4:
                        a = Convert.ToInt32(ValorIntroduit());
                        Console.Clear();
                        Console.WriteLine($"El factorial de {a} es {Factorial(a)}");
                        CompteEnrere();
                        break;
                    case 5:
                        a = Convert.ToInt32(ValorIntroduit());
                        b = Convert.ToInt32(ValorIntroduit());
                        Console.Clear();
                        Console.WriteLine($"El Combinatori de {a} i {b} es {Combinatori(a, b)}");
                        CompteEnrere();
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
        static int Mcm(int num1, int num2)
        {
            int mcm = int.MaxValue;
            bool trobat = false;
            Maxim(num1, num2);
            for (int i = num1; !trobat; i++)
            {
                if (i % num2 == 0 && i % num1 == 0)
                {
                    trobat = true;
                    mcm = i;
                }
            }
            return mcm;
        }
        static int Factorial(int num)
        {
            int acum = 1;
            for (int i = 1; i <= num; i++)
            {
                acum = acum * i;
            }
            return acum;
        }
        static double Combinatori(int n, int m)
        {
            double calcul, factN = 1, factM = 1, nMenysM, factNMenysM = 1;

            for (int i = 2; i <= n; i++)
                factN = factN * i;
            for (int i = 2; i <= m; i++)
                factM = factM * i;
            nMenysM = n - m;
            for (int i = 2; i <= nMenysM; i++)
                factNMenysM = factNMenysM * i;
            calcul = factN / (factM * factNMenysM);
            return calcul;
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
