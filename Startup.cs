using DataAccess;
using GameIndustryModule2.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tewr.Blazor.FileReader;

namespace GameIndustryModule2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ���� 18 (4) ������������� ���� ������ � ������ StartUp
            services.AddDbContext<ApplicationDbContext>(options => 
                         options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddRazorPages();
            services.AddServerSideBlazor();

            // ���� 9 ������ 2(8)
            //services.AddSingleton<IRepository, MockGamesRepository>();

            // ���� 18 (12) �������� ������������ �������� ���� � ����� StartUp
            services.AddScoped<IRepository, SqlGamesRepository>();

            // ���� 13 (10)
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
