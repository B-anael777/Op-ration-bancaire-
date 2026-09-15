// Exercice 10 : Test de l'héritage
var cc = new CompteCourant("CC-001", "Alice", 100m, 200m);
cc.Debiter(250m); // Utilise le découvert autorisé

var ce = new CompteEpargne("CE-001", "Alice", 0.03m, 1000m);
ce.CalculerInterets(); // 3% sur 1000 = +30€

Console.WriteLine($"Compte Courant Alice : {cc.Solde} €");
Console.WriteLine($"Compte Épargne Alice : {ce.Solde} €");