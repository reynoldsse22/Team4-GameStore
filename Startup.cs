using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Blazored.SessionStorage;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredSessionStorage();
            services.AddDbContext<GameDbContext>(options =>
            {
                options.UseSqlite("Data Source = Games.db");
            });
            services.AddScoped<GameDbService>();
            services.AddDbContext<CartDbContext>(options =>
            {
                options.UseSqlite("Data Source = Cart.db");
            });
            services.AddScoped<CartDbService>();
            services.AddDbContext<WishlistDbContext>(options =>
            {
                options.UseSqlite("Data Source = Wishlist.db");
            });
            services.AddScoped<WishlistDbService>();
            services.AddDbContext<UserDbContext>(options =>
            {
                options.UseSqlite("Data Source = User.db");
            });
            services.AddScoped<UserDbService>();
            services.AddDbContext<ReviewDbContext>(options =>
            {
                options.UseSqlite("Data Source = Review.db");
            });
            services.AddScoped<ReviewDbService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>();
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

            app.UseAuthentication();
            
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
