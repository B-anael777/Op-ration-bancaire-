Compte compte = new Compte();
compte.Numero = "FR001";
compte.Titulaire = "Alice";
compte.Solde = 1000m;

compte.Crediter(200m);
compte.Debiter(50m);

Console.WriteLine($"Solde d'Alice : {compte.Solde} €");