using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzariaWebApp.Data;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // ...
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
        );
        // ...
    }
}
