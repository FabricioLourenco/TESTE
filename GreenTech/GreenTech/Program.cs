using AutoMapper;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;
using GreenTech.Repository.Repository;
using GreenTech.Service.Interface;
using GreenTech.Service.Service;
using Microsoft.EntityFrameworkCore;

namespace GreenTech
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Injeção de Dependencias
            builder.Services.AddDbContext<GreenTechContext>(options => options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:GreenTech")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddScoped<IUsuarioService, UsuarioService>();
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            builder.Services.AddScoped<IRankingService, RankingService>();
            builder.Services.AddScoped<IRankingRepository, RankingRepository>();

            builder.Services.AddScoped<IEnderecoService, EnderecoService>();
            builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            builder.Services.AddScoped<IDadosService, DadosService>();
            builder.Services.AddScoped<IDadosRepository, DadosRepository>();

            builder.Services.AddScoped<ICadastroResiduoService, CadastroResiduoService>();
            builder.Services.AddScoped<ICadastroResiduoRepository, CadastroResiduoRepository>();

            #endregion

            #region Mapper
            MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfiguration => { mapperConfiguration.AddMaps(new[] { "GreenTech.Service" }); });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());
            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}