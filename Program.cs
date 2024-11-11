using lab3.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews(); // Ensure this line is present
builder.Services.AddAuthorization(); // Add this line to register authorization services

// Register your custom services
builder.Services.AddScoped<IContactService, MemoryContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Add these lines in the correct order
app.UseAuthentication(); // If you plan to use authentication
app.UseAuthorization();  // Ensure this is after UseRouting

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
