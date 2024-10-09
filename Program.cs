namespace BankkonsolApplikation
{



    

    namespace Bankkonsolapplikation
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\nVälkommen till Bankkonsolapplikation!");
                    Console.WriteLine("1. Skapa personkonto");
                    Console.WriteLine("2. Skapa sparkonto");
                    Console.WriteLine("3. Skapa investeringskonto");
                    Console.WriteLine("4. Avsluta");

                    int val;
                    while (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 4)
                    {
                        Console.Write("Felaktigt val. Välj 1, 2, 3 eller 4: ");
                    }

                    Konto konto = null;

                    switch (val)
                    {
                        case 1:
                            konto = new Personkonto("12345", "John Doe", 1000);
                            Console.WriteLine("Personkonto skapat.");
                            break;
                        case 2:
                            konto = new Sparkonto("67890", "Jane Doe", 2000);
                            Console.WriteLine("Sparkonto skapat.");
                            break;
                        case 3:
                            konto = new Investeringskonto("11223", "Anna Doe", 5000);
                            Console.WriteLine("Investeringskonto skapat.");
                            break;
                        case 4:
                            Console.WriteLine("Hejdå!");
                            return;
                    }

                    if (konto != null)
                    {
                        Console.WriteLine($"Kontoinformation: Namn: {konto.Namn}, Nummer: {konto.Nummer}, Saldo: {konto.Balans}");
                    }

                    Console.WriteLine("Tryck på en valfri tangent för att fortsätta...");
                    Console.ReadKey(true);
                }
            }
        }
    }

}
