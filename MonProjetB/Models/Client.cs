using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Client
{
    public string Nom { get; set; }
    private readonly List<Compte> _comptes;

    public ReadOnlyCollection<Compte> Comptes => _comptes.AsReadOnly();

    public Client(string nom)
    {
        Nom = nom;
        _comptes = new List<Compte>();
    }

    public void AjouterCompte(Compte compte)
    {
        if (compte != null)
        {
            _comptes.Add(compte);
        }
    }

    public decimal ObtenirSoldeTotal()
    {
        decimal total = 0m;
        foreach (var compte in _comptes)
        {
            total += compte.Solde;
        }
        return total;
    }
}