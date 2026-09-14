// 1. Code exécutable (Top-Level Statements)
Compte c1 = new Compte();
c1.Numero = "FR001";
c1.Titulaire = "Alice";
c1.Solde = 1000m;

Compte c2 = new Compte();
c2.Numero = "FR002";
c2.Titulaire = "Bob";
c2.Solde = 500m;

Console.WriteLine($"C1: {c1.Numero} | {c1.Titulaire} | {c1.Solde} €");
Console.WriteLine($"C2: {c2.Numero} | {c2.Titulaire} | {c2.Solde} €");

c1.Solde = 1200m;

Console.WriteLine("Après modification de C1 :");
Console.WriteLine($"C1: {c1.Solde} €");
Console.WriteLine($"C2: {c2.Solde} € (inchangé)");

// 2. Déclaration de la classe (TOUJOURS tout en bas du fichier)
public class Compte
{
    public string Numero { get; set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; set; }
}