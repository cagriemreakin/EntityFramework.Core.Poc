// See https://aka.ms/new-console-template for more information

using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

await using(var context =new AppDbContext())
{
    var products = await context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"Id:{p.Id},Name: {p.Name},Price: {p.Price},Stock: {p.Stock}");
        
    });
}