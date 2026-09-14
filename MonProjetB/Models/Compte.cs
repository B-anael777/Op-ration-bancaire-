public class Compte
{
    public string Numero { get; } // Impossible à changer après construction
    public string Titulaire { get; set; }
    public decimal Solde { get; private set; } // Modifiable seulement dans Compte.cs

    public Compte(string numero, string titulaire, decimal soldeInitial = 0m)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = soldeInitial;
    }

    public void Crediter(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
        }
    }

    public void Debiter(decimal montant)
    {
        if (montant > 0 && Solde >= montant)
        {
            Solde -= montant;
        }
    }
}