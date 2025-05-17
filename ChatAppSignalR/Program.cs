var builder = WebApplication.CreateBuilder(args);

// 🔴 Agrega servicios ANTES de Build()
builder.Services.AddSignalR();

var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => Results.Redirect("/index.html"));
app.MapHub<ChatHub>("/chathub");

app.Run();
