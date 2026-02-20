using ApiFuncional.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddApiConfig()         // Controllers
    .AddCorsConfig()        // CORS 
    .AddSwaggerConfig()     // Swagger
    .AddDbContextConfig()   //Conectando Banco de Dados
    .AddIdentityConfig();   // Identity

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else
{
    app.UseCors("Production");
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();