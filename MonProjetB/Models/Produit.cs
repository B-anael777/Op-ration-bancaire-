public class Produit
{
    public string Reference { get; }
    public string Nom { get; set; }
    public decimal Prix { get; private set; }
    public int Stock { get; private set; }

    public Produit(string reference, string nom, decimal prix, int stockInitial = 0)
    {
        if (string.IsNullOrWhiteSpace(reference))
            throw new ArgumentException("La référence est obligatoire.");

        Reference = reference;
        Nom = nom;
        ChangerPrix(prix);
        
        if (stockInitial > 0)
        {
            Stock = stockInitial;
        }
    }

    public void ChangerPrix(decimal nouveauPrix)
    {
        if (nouveauPrix < 0)
        {
            Console.WriteLine("Erreur : Le prix ne peut pas être négatif.");
            return;
        }
        Prix = nouveauPrix;
    }

    public void EntrerStock(int quantite)
    {
        if (quantite <= 0) return;
        Stock += quantite;
    }

    public bool SortirStock(int quantite)
    {
        if (quantite <= 0 || quantite > Stock)
        {
            Console.WriteLine("Opération refusée : Stock insuffisant ou quantité invalide.");
            return false;
        }
        Stock -= quantite;
        return true;
    }
}