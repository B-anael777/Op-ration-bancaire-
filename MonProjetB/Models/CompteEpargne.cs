public class CompteEpargne : Compte
{
    public decimal TauxInteret { get; set; }

    public CompteEpargne(string numero, string titulaire, decimal tauxInteret, decimal soldeInitial = 0m)
        : base(numero, titulaire, soldeInitial)
    {
        TauxInteret = tauxInteret;
    }

    public void CalculerInterets()
    {
        decimal interets = Solde * TauxInteret;
        Crediter(interets);
    }
}