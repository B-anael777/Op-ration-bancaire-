namespace MonProjetB.Models;

// Classe de base
public class CompteBancaire
{
    public int Id { get; set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; protected set; }

    public CompteBancaire(int id, string titulaire)
    {
        Id = id;
        Titulaire = titulaire;
        Solde = 500m; // Solde de départ par défaut
    }

    public virtual void Debiter(decimal montant)
    {
        Solde -= montant;
    }
}

// Compte Courant
public class CompteCourant : CompteBancaire
{
    public CompteCourant(int id, string titulaire) : base(id, titulaire) { }
}

// Compte Étudiant
public class CompteEtudiant : CompteBancaire
{
    public CompteEtudiant(int id, string titulaire) : base(id, titulaire) { }
}

// Compte Premium
public class ComptePremium : CompteBancaire
{
    public ComptePremium(int id, string titulaire) : base(id, titulaire) { }
}