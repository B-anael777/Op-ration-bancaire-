public class Compte
{
    public string Numero { get; }
    public string Titulaire { get; set; }
    public decimal Solde { get; private set; }

    // Le constructeur force la saisie du numéro et du titulaire
    public Compte(string numero, string titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = 0m;
    }

    public void Crediter(decimal montant)
    {
        if (montant > 0) Solde += montant;
    }

    public void Debiter(decimal montant)
    {
        if (montant > 0 && Solde >= montant) Solde -= montant;
    }
}