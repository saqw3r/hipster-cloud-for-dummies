var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument(option => {
    option.Title = "Hipster.Api";
});

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

app.UseOpenApi();

app.UseSwaggerUi3();

// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapControllers();
// });

app.MapControllers();

app.Run();
