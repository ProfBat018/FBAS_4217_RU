using EF2.Data.DbContexts;

using SupermarketDbContext context = new();

//context.Products.Add(new()
//{
//    Name = "Qatiq",
//    ProdDate = DateTime.Now,
//    EndDate = DateTime.Now + TimeSpan.FromDays(14)
//});

//context.SaveChanges();


context.Stock.Add(new()
{
    Count = 5,
    ProductId = context.Products.First(x => x.Name == "Qatiq").Id
}) ;

context.SaveChanges();
