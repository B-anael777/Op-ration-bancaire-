class Program
{
    static void Main()
    {
        decimal soldeCourant = 1000m;

        soldeCourant = Crediter(soldeCourant, 200m);
        soldeCourant = Debiter(soldeCourant, 150m);
        soldeCourant = Debiter(soldeCourant, 2000m); // Refusé

        Console.WriteLine($"Solde final : {soldeCourant} €");
    }

    static decimal Crediter(decimal solde, decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : Le montant du crédit doit être strictement positif.");
            return solde;
        }
        return solde + montant;
    }

    static decimal Debiter(decimal solde, decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : Le montant du débit doit être strictement positif.");
            return solde;
        }
        if (montant > solde)
        {
            Console.WriteLine("Opération refusée : Solde insuffisant.");
            return solde;
        }
        return solde - montant;
    }
}