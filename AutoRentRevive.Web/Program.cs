using AutoRentRevive.Web.Services.DepartmentService;
using AutoRentRevive.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//****************************API and webApplication linker*********************************************
builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client => 
{
    client.BaseAddress = new Uri("https://localhost:7060/");
});
builder.Services.AddScoped<DepartmentListBase>();
builder.Services.AddHttpClient<IDepartmentService, DepartmentService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7060/");
});

//builder.Services.AddControllers()
//    .AddJsonOptions(options =>
//    {
//        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
//    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapRazorPages();
app.MapGet("/", context =>
{
    context.Response.Redirect("/home"); // Your custom page
    return Task.CompletedTask;
});

app.Run();
