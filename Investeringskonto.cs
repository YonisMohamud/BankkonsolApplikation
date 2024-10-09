using BankkonsolApplikation.Bankkonsolapplikation;

namespace Bankkonsolapplikation
{
    public class Investeringskonto : Konto
    {
        public Investeringskonto(string nummer, string namn, decimal balans)
            : base(nummer, namn, balans)
        {
        }
    }
}

