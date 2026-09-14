Compte compte = new Compte("FR001", "Alice", 1000m);

// compte.Solde = 1_000_000m; // <-- Si tu décommentes cette ligne, C# affiche une erreur de compilation !

compte.Crediter(500m); // Fonctionne car Crediter() est à l'intérieur de la classe
Console.WriteLine($"Solde sécurisé : {compte.Solde} €");