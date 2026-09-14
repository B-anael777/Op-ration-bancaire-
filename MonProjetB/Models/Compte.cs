public class Compte
{
    public string Numero { get; }
    public string Titulaire { get; set; }
    public decimal Solde { get; private set; }

    // Constructeur principal
    public Compte(string numero, string titulaire, decimal soldeInitial)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = soldeInitial >= 0 ? soldeInitial : 0m;
    }

    // Surcharge qui appelle le constructeur principal avec un solde à 0m
    public Compte(string numero, string titulaire) : this(numero, titulaire, 0m)
    {
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