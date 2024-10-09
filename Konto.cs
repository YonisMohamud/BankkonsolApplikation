

namespace BankkonsolApplikation
{


    namespace Bankkonsolapplikation
    {
        public class Konto
        {
            public string Nummer { get; set; }
            public string Namn { get; set; }
            public decimal Balans { get; set; }

            public Konto(string nummer, string namn, decimal balans)
            {
                Nummer = nummer;
                Namn = namn;
                Balans = balans;
            }

            public void Insättning(decimal belopp)
            {
                Balans += belopp;
            }

            public bool Uttag(decimal belopp)
            {
                if (Balans >= belopp)
                {
                    Balans -= belopp;
                    return true;
                }
                return false;
            }
        }
    }







}

