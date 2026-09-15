public class Compte
{
    public string Numero { get; }
    public string Titulaire { get; set; }
    public decimal Solde { get; protected set; } // accessible dans les classes filles

    public Compte(string numero, string titulaire, decimal soldeInitial = 0m)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = soldeInitial >= 0 ? soldeInitial : 0m;
    }

    public virtual void Crediter(decimal montant)
    {
        if (montant > 0) Solde += montant;
    }

    public virtual bool Debiter(decimal montant)
    {
        if (montant > 0 && Solde >= montant)
        {
            Solde -= montant;
            return true;
        }
        return false;
    }
}