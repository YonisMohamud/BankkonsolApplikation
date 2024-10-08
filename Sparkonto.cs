

namespace Bankkonsolapplikation
{
    // Sparkonto ärver från Konto
    public class Sparkonto : Konto
    {
        public Sparkonto(string nummer, string namn, decimal balans)
            : base(nummer, namn, balans)
        {
        }

        // Specifik funktionalitet för Sparkonto kan läggas till här
    }
}








