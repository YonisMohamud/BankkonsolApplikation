

namespace Bankkonsolapplikation
{
    // Investeringskonto ärver från Konto
    public class Investeringskonto : Konto
    {
        public Investeringskonto(string nummer, string namn, decimal balans)
            : base(nummer, namn, balans)
        {
        }

        // Specifik funktionalitet för Investeringskonto kan läggas till här
    }
}















