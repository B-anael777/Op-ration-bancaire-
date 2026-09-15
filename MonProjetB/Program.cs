// Exercice 11 : Mini-projet de synthèse
Client client = new Client("Bob Martin");

CompteCourant compteCourant = new CompteCourant("CC-500", client.Nom, 500m, 100m);
CompteEpargne compteEpargne = new CompteEpargne("CE-500", client.Nom, 0.03m, 2000m);

client.AjouterCompte(compteCourant);
client.AjouterCompte(compteEpargne);

compteCourant.Debiter(150m);
compteEpargne.Crediter(300m);
compteEpargne.CalculerInterets();

Console.WriteLine($"=== Synthèse du client : {client.Nom} ===");
foreach (var c in client.Comptes)
{
    Console.WriteLine($"[{c.GetType().Name}] N° {c.Numero} | Solde : {c.Solde:F2} €");
}

Console.WriteLine($"Solde global du patrimoine : {client.ObtenirSoldeTotal():F2} €");