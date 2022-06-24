using ControleDespesas.Infraestrutura.BancoDeDados;
using ControleDespesas.IServices;
using ControleDespesas.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DespesasContext>();

builder.Services.AddScoped<IDespesasService, DespesasService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Despesa}/{action=Index}/{id?}");

app.Run();
