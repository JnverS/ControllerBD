using ControllerBD.Interfaces;
using ControllerBD.Repository;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

public class Startup {

    private IConfigurationRoot _config;
    public Startup(IHostingEnvironment host)
    {
        _config = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("appsettings.json").Build();
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(_config.GetConnectionString("DefaultConnection")));
        services.AddMvc(option => option.EnableEndpointRouting = false);
        services.AddTransient<IUser, UsersRepository>();
    }
    public void Configure(IApplicationBuilder app, IHostingEnvironment env) { 
       app.UseDeveloperExceptionPage();
        app.UseStaticFiles();
        app.UseStaticFiles();
        app.UseMvcWithDefaultRoute();
    }
}
