namespace ConsoleApp1
{
    internal class Program
    {
     

















  }      


namespace BankApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                bank.Run();
            }
        }

        class Account
        {
            public string AccountNumber { get; private set; }
            public string AccountType { get; private set; }
            public decimal Balance { get; private set; }

            public Account(string accountNumber, string accountType, decimal initialBalance = 0)
            {
                AccountNumber = accountNumber;
                AccountType = accountType;
                Balance = initialBalance;
            }

            // Metod för insättning
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"{amount} har satts in på konto {AccountNumber}. Ny balans: {Balance}");
                }
                else
                {
                    Console.WriteLine("Insättningsbelopp måste vara positivt.");
                }
            }

            // Metod för uttag
            public void Withdraw(decimal amount)
            {
                if (amount > 0)
                {
                    if (amount <= Balance)
                    {
                        Balance -= amount;
                        Console.WriteLine($"{amount} har tagits ut från konto {AccountNumber}. Ny balans: {Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Otillräckligt saldo för detta uttag.");
                    }
                }
                else
                {
                    Console.WriteLine("Uttagsbelopp måste vara positivt.");
                }
            }

            // Metod för att kontrollera saldot
            public decimal GetBalance()
            {
                return Balance;
            }
        }

        class Bank
        {
            private Dictionary<string, Account> accounts = new Dictionary<string, Account>();

            // Skapa konton för bankens användare
            public Bank()
            {
                accounts["1"] = new Account("1", "Sparkonto", 1000);
                accounts["2"] = new Account("2", "Lönekonto", 2000);
                accounts["3"] = new Account("3", "Företagskonto", 3000);
            }

            // Kör applikationen
            public void Run()
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine("Välj ett av alternativ:");
                    Console.WriteLine("1. Visa saldo");
                    Console.WriteLine("2. Sätt in pengar");
                    Console.WriteLine("3. Ta ut pengar");
                    Console.WriteLine("4. Överför pengar");
                    Console.WriteLine("5. Avsluta");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CheckBalance();
                            break;
                        case "2":
                            DepositMoney();
                            break;
                        case "3":
                            WithdrawMoney();
                            break;
                        case "4":
                            TransferMoney();
                            break;
                        case "5":
                            running = false;
                            Console.WriteLine("Avslutar programmet.");
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            break;
                    }
                }
            }

            // Kontrollera saldo för ett specifikt konto
            private void CheckBalance()
            {
                Console.Write("Ange kontonummer: ");
                string accountNumber = Console.ReadLine();

                if (accounts.ContainsKey(accountNumber))
                {
                    Account account = accounts[accountNumber];
                    Console.WriteLine($"Saldo för konto {accountNumber} ({account.AccountType}): {account.GetBalance()}");
                }
                else
                {
                    Console.WriteLine("Kontonumret finns inte.");
                }
            }

            // Sätta in pengar på ett konto
            private void DepositMoney()
            {
                Console.Write("Ange kontonummer: ");
                string accountNumber = Console.ReadLine();

                if (accounts.ContainsKey(accountNumber))
                {
                    Console.Write("Ange insättningsbelopp: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        accounts[accountNumber].Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt belopp.");
                    }
                }
                else
                {
                    Console.WriteLine("Kontonumret finns inte.");
                }
            }

            // Ta ut pengar från ett konto
            private void WithdrawMoney()
            {
                Console.Write("Ange kontonummer: ");
                string accountNumber = Console.ReadLine();

                if (accounts.ContainsKey(accountNumber))
                {
                    Console.Write("Ange uttagsbelopp: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        accounts[accountNumber].Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt belopp.");
                    }
                }
                else
                {
                    Console.WriteLine("Kontonumret finns inte.");
                }
            }

            // Överför pengar mellan konton
            private void TransferMoney()
            {
                Console.Write("Ange avsändarens kontonummer: ");
                string fromAccountNumber = Console.ReadLine();

                Console.Write("Ange mottagarens kontonummer: ");
                string toAccountNumber = Console.ReadLine();

                if (accounts.ContainsKey(fromAccountNumber) && accounts.ContainsKey(toAccountNumber))
                {
                    Console.Write("Ange belopp att överföra: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        if (amount > 0 && amount <= accounts[fromAccountNumber].GetBalance())
                        {
                            accounts[fromAccountNumber].Withdraw(amount);
                            accounts[toAccountNumber].Deposit(amount);
                            Console.WriteLine($"{amount} överfördes från konto {fromAccountNumber} till konto {toAccountNumber}.");
                        }
                        else
                        {
                            Console.WriteLine("Otillräckligt saldo eller ogiltigt belopp.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt belopp.");
                    }
                }
                else
                {
                    Console.WriteLine("Ett eller båda kontonumren finns inte.");
                }
            }
        }
    }







}
    

