var c1 = new Compte("FR001", "Alice");       // Solde par défaut : 0€
var c2 = new Compte("FR002", "Bob", 500m);    // Solde initial : 500€

Console.WriteLine($"C1 ({c1.Titulaire}) : {c1.Solde} €");
Console.WriteLine($"C2 ({c2.Titulaire}) : {c2.Solde} €");