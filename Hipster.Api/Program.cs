using Hipster.Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument(option => {
    option.Title = "Hipster.Api";
});

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Database"))
);

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

app.UseRouting();

app.UseCors(o =>
{
    o.AllowAnyOrigin();
    o.AllowAnyHeader();
    o.AllowAnyMethod();
});

app.UseOpenApi();

app.UseSwaggerUi3();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

//app.MapControllers();

app.Run();
