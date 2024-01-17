namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcio; 

            Console.WriteLine("---MENU MATEMATIC---\n");
            Console.WriteLine("1. MAXIM");
            Console.WriteLine("2. MCD");
            Console.WriteLine("3. MCM");
            Console.WriteLine("4. FACTORIAL");
            Console.WriteLine("5. COMBINATORI");
            Console.WriteLine("6. DIVISOR MAJOR");
            Console.WriteLine("7. ES PRIMER");
            Console.WriteLine("8. NPRIMERS PRIMERS\n");
            Console.WriteLine("0. SORITR");

            opcio = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            if (opcio == 0 || opcio == 1 || opcio == 2 || opcio == 3 || opcio == 4 || opcio == 5 || opcio == 6 || opcio == 7 || opcio == 8)
            {
                switch (opcio)
                { 
                    case 0 :
                        Console.WriteLine("a");
                        break;
                    case 1:
                        Maxim();
                        break;
                    case 2:
                        Mcd();
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
            else
            {
                Console.WriteLine("Opcio incorrecte, torna a escollir una opcio.");
                
            }
        }
        static void Maxim()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero mes gran es el " + num1);
            }
            else
            {
                Console.WriteLine("El numero mes gran es el " + num2);
            }
        }
        static void Mcd()
        {
            int num1, num2;

            Console.Write("Dona un numero --> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dona un altre numero --> ");
            num2 = Convert.ToInt32(Console.ReadLine());
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
