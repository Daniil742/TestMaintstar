using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TestMaintstar.Application.Interfaces;
using TestMaintstar.Application.Models.DB;
using TestMaintstar.Application.Models.Entities;
using TestMaintstar.Application.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);
RegisterServices(builder.Services);

var app = builder.Build();
Configure(app);



void RegisterServices(IServiceCollection services)
{
    services.AddMvc();
    services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    });
    services.AddScoped<IDataModel<Picture>, PictureRepository>();
}

void Configure(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        DbInitializer.Initialize(db);
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}


//var T_indicators = new List<Indicator>();
//var T_resources = new List<Resource>();
//var T_years = new List<Year>();

//var T_values = new List<Value>();
//var T_multiplication = new List<Multiplication>();
//var T_convertation = new List<Convertation>();

//for (var i = 0; i < 5; i++)
//{
//    for (var r = 0; r < 5; r++)
//    {
//        for (var y = 0; y < 5; y++)
//        {
//            var M_values = T_values.Where(x => x.Indicator.Name == T_indicators[i].Name &&
//                                               x.Resource.Name == T_resources[r].Name &&
//                                               x.Year.Name == T_years[y].Name);

//            var M_calculated = T_multiplication
//        }
//    }
//}

//class Indicator
//{
//    public string Name { get; set; }
//}

//class Resource
//{
//    public string Name { get; set; }
//}

//class Year
//{
//    public string Name { get; set; }
//}

//class Value
//{
//    public Indicator Indicator { get; set; }
//    public Resource Resource { get; set; }
//    public Year Year { get; set; }
//    public string Unit { get; set; }
//    public double Meaning { get; set; }
//}

//class Multiplication
//{
//    public string Name { get; set; }
//    public string BaseUM { get; set; }
//    public string CalculatedUM { get; set; }
//    public int E { get; set; }
//}

//class Convertation
//{
//    public string Name { get; set; }
//    public string OriginalUM { get; set; }
//    public string ResultingUM { get; set; }
//    public double K { get; set; }
//}