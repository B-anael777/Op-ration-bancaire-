decimal solde = 1000m;
decimal montant = -150m; // Tester avec des valeurs positives et négatives

if (montant > 0)
{
    solde += montant;
    Console.WriteLine($"Crédit effectué. Nouveau solde : {solde} €");
}
else if (montant < 0)
{
    decimal debit = -montant; // Conversion de la valeur négative en valeur absolue
    if (solde >= debit)
    {
        solde -= debit;
        Console.WriteLine($"Débit effectué. Nouveau solde : {solde} €");
    }
    else
    {
        Console.WriteLine("Opération refusée : Solde insuffisant.");
    }
}
else
{
    Console.WriteLine("Le montant de l'opération ne peut pas être nul.");
}

// 2. CONFIGURATION ASP.NET CORE (Au milieu)
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

