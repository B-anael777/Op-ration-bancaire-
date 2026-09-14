public class Compte
{
    public string Numero { get; set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; set; }

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
        else
        {
            Console.WriteLine("Débit refusé : solde insuffisant ou montant invalide.");
        }
    }
}