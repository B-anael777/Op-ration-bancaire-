namespace MonProjetB.Models;

public class Compte
{
    public string Numero { get; }
    public decimal Solde { get; private set; }

    public Compte(string numero, decimal soldeInitial)
    {
        Numero = numero;
        Solde = soldeInitial;
    }
}