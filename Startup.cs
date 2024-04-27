using Microsoft.EntityFrameworkCore;
using BankAccountManagement.Data;

public class Startup
{
    public IConfiguration Configuration { get; } // Declarar una propiedad para Configuration


    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        var connectionString = Configuration.GetConnectionString("DefaultConnection");
        
        services.AddDbContext<BankAccountContext>(options =>
            options.UseNpgsql(connectionString));

        services.AddDbContext<BankAccountContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
