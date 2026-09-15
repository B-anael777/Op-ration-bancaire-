// Exercice 9 : Test de la classe Produit
var produit = new Produit("REF-001", "Clavier Mécanique", 79.99m, 10);
produit.EntrerStock(5);
produit.SortirStock(3);
Console.WriteLine($"Produit : {produit.Nom} | Prix : {produit.Prix} € | Stock : {produit.Stock}");