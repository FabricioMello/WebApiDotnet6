using BackendAVMB.Context;
using BackendAVMB.Interfaces;
using BackendAVMB.Rest;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextPool<AppDbContext>(options =>
                options.UseMySql(mySqlConnection, 
                ServerVersion.AutoDetect(mySqlConnection)));

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});

builder.Services.AddScoped<IEnvelopeApi, EnvelopeApiRest>();
builder.Services.AddScoped<ISignatarioApi, SignatarioApiRest>();
builder.Services.AddScoped<IEncaminhaParaAssinaturaApi, EncaminharParaAssinaturaApiRest>();
builder.Services.AddScoped<IGetDadosEnvelope, GetDadosApiRest>();
builder.Services.AddScoped<ISalvarEDownload, SalvarEDownloadApiRest>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
