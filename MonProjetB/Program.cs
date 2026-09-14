var compte = new Compte("FR001", "Alice");
// var compteInvalide = new Compte(); // Impossible ! Le constructeur sans paramètre n'existe plus.

Console.WriteLine($"Compte : {compte.Numero} | Titulaire : {compte.Titulaire} | Solde : {compte.Solde} €");