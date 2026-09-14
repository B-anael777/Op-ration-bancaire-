using Microsoft.AspNetCore.Mvc;
using MonProjetB.Models;

namespace MonProjetB.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // 1. Création des trois comptes
        var courant = new CompteCourant(1, "Dupont");
        var etudiant = new CompteEtudiant(2, "Martin");
        var premium = new ComptePremium(3, "Durand");

        // 2. Traitement (Débits)
        courant.Debiter(100m);
        etudiant.Debiter(200m);
        premium.Debiter(300m);

        // Affichage dans le terminal VS Code
        // Console.WriteLine($"Solde du compte courant : {courant.Solde}");
        // Console.WriteLine($"Solde du compte étudiant : {etudiant.Solde}");
        // Console.WriteLine($"Solde du compte premium : {premium.Solde}");

        // 3. Regroupement dans une liste
        var listeComptes = new List<object> { courant, etudiant, premium };

        // 4. Envoi de la liste à la vue HTML (Requis pour corriger l'erreur)
        return View(listeComptes);
    }
}