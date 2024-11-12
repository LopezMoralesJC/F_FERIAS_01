using System.Text;
using F_Ferias.AccessData;
using F_Ferias.Models.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLConnection0")));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    // options.Password.RequiredUniqueChars = 4;
    // options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    // options.Lockout.MaxFailedAccessAttempts = 3;
})
    .AddRoleManager<RoleManager<ApplicationRole>>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


    builder.Services.AddAuthentication(options =>{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme    = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme             = JwtBearerDefaults.AuthenticationScheme; 
        }).AddJwtBearer(options => {
            options.TokenValidationParameters = new TokenValidationParameters {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true , 
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
            };
        });




builder.Services.AddAuthorization(Options => {
    Options.AddPolicy("AdministradorPolicy", policy => policy.RequireRole("Administrador"));                                                                         
    // Options.AddPolicy("Interno_Policy", policy => policy.RequireRole("Interno"));
    // Options.AddPolicy("Externo_Policy", policy => policy.RequireRole("Externo"));
    // Options.AddPolicy("SuperUsuario_Policy", policy => policy.RequireRole("SuperUsuario"));
     Options.AddPolicy("Administrador_Consejero_Laboral_Policy", policy => policy.RequireRole("Administrador Consejero Laboral"));
     Options.AddPolicy("Consejero_Laboral_Policy", policy => policy.RequireRole("Consejero Laboral"));
    // Options.AddPolicy("OSNE_Policy", policy => policy.RequireRole("OSNE"));
    // Options.AddPolicy("Persona_Policy", policy => policy.RequireRole("Persona"));
    // Options.AddPolicy("Empleador_Policy", policy => policy.RequireRole("Empleador"));
    // Options.AddPolicy("Persona_Aliado_PCM_Policy", policy => policy.RequireRole("Persona Aliado PCM"));
});


builder.Services.AddSwaggerGen(Options => {
        Options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme,
                                securityScheme: new OpenApiSecurityScheme {
                                    Name = "Authorization",
                                    Description = "Enter the bearer Authorization  : `Bearer Genreated-JWT-Token",
                                    In = ParameterLocation.Header,
                                    Type = SecuritySchemeType.ApiKey,
                                    Scheme = "Bearer" 
                                });
                                Options.AddSecurityRequirement(new OpenApiSecurityRequirement 
                                {
                                {
                                    new OpenApiSecurityScheme
                                    {
                                        Reference = new OpenApiReference 
                                        {
                                            Type = ReferenceType.SecurityScheme,
                                            Id = JwtBearerDefaults.AuthenticationScheme
                                        }
                                    }, new string[]{}
                                }    
                                });
    });
    
Ioc.AddDependency(builder.Services);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
    
}
app.UseHttpsRedirection();
app.UseAuthentication(); 
app.UseAuthorization();
app.MapControllers();
app.Run();
