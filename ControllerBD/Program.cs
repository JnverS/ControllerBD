
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[]args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }
    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();

}


/*
var builder = WebApplication.CreateBuilder(args);

// получаем строку подключени€ из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавл€ем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=index}/{id?}");
app.Run();

/*
app.MapGet("/get", async (ApplicationContext db) => await db.Users.ToListAsync());

app.MapGet("/get/{id:int}", async (int id, ApplicationContext db) =>
{
    // получаем пользовател€ по id
    User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

    // если не найден, отправл€ем статусный код и сообщение об ошибке
    if (user == null) return Results.NotFound(new { message = "ѕользователь не найден" });

    // если пользователь найден, отправл€ем его
    return Results.Json(user);
});

app.MapPost("/post", async (User user, ApplicationContext db) =>
{
    // добавл€ем пользовател€ в массив
    await db.Users.AddAsync(user);
    await db.SaveChangesAsync();
    return user;
});


app.Run();
*/