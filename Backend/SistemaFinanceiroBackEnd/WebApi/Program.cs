using Domain.Interfaces.Generics;
using Domain.Interfaces.ICategoria;
using Domain.Interfaces.IDespesa;
using Domain.Interfaces.ISistemaFinanceiro;
using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddDbContext<ContextBase>(options => 
        options.UseSqlServer(builder.Configuration.
        GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<ContextBase>();


// INTERFACE E REPOSITORIO
builder.Services.AddSingleton(typeof(InterfaceGneric<>), typeof(RepositoryGeneric<>));
builder.Services.AddSingleton<InterfaceCategoria, RepositorioCategoria>();
builder.Services.AddSingleton<InterfaceDespesa, RepositorioDespesa>();
builder.Services.AddSingleton<InterfaceSistemaFinanceiro, RepositorioSistemaFinanceiro>();
builder.Services.AddSingleton<InterfaceUsuarioSistemaFinanceiro, RepositorioUsuarioSistemaFinanceiro>();









var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
