using Microsoft.EntityFrameworkCore;
using Sprint03.Infrastructure.Data;
using Sprint03.Infrastructure.Repositories;
using Microsoft.OpenApi.Models;
using Oracle.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Sprint03.Services;

var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Configuração do banco de dados Oracle.
/// </summary>
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

/// <summary>
/// Registra o repositório NomeUsuarioRepository para injeção de dependência.
/// </summary>
builder.Services.AddScoped<NomeUsuarioRepository>();
builder.Services.AddHttpClient<ICdcApiService, CdcApiService>();


/// <summary>
/// Adiciona suporte a Controllers na API.
/// </summary>
builder.Services.AddControllers();

/// <summary>
/// Configuração do Swagger/OpenAPI para documentação da API.
/// </summary>
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Sprint03 API",
        Version = "v1",
        Description = "API para gerenciamento de usuários."
    });

    // Habilita suporte para anotações no Swagger
    options.EnableAnnotations();
});

var app = builder.Build();

/// <summary>
/// Se o ambiente for de desenvolvimento, ativa o Swagger para documentação da API.
/// </summary>
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<Sprint03.Middleware.ExceptionMiddleware>();

/// <summary>
/// Aplica redirecionamento HTTPS para segurança.
/// </summary>
app.UseHttpsRedirection();

/// <summary>
/// Habilita autorização para proteger os endpoints, se necessário.
/// </summary>
app.UseAuthorization();

/// <summary>
/// Mapeia as rotas dos controllers para a API.
/// </summary>
app.MapControllers();

/// <summary>
/// Inicia a aplicação.
/// </summary>
app.Run();

