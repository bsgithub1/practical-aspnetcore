var builder = WebApplication.CreateBuilder();
builder.Services.AddRazorComponents();

var app = builder.Build();

app.MapRazorComponents<RazorFormHandlingFive.Pages.App>();
app.Run();


