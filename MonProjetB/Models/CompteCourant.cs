public class CompteCourant : Compte
{
    public decimal DecouvertAutorise { get; set; }

    public CompteCourant(string numero, string titulaire, decimal soldeInitial = 0m, decimal decouvertAutorise = 0m)
        : base(numero, titulaire, soldeInitial)
    {
        DecouvertAutorise = decouvertAutorise;
    }

    public override bool Debiter(decimal montant)
    {
        if (montant > 0 && (Solde + DecouvertAutorise) >= montant)
        {
            Solde -= montant;
            return true;
        }
        Console.WriteLine("Débit refusé : Découvert autorisé dépassé.");
        return false;
    }
}