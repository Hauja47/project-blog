using JustaBlog.Contracts.Enums;
using JustaBlog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BlogDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("BloggingContext"),
        o => o
            .MapEnum<RecordStatus>("record_status")
            .MapEnum<PostStatus>("post_status")
            .MapEnum<InteractionType>("interaction_type"));

    options.UseOpenIddict<Guid>();
});

builder.Services.AddOpenIddict()
    .AddCore(options =>
    {
        options
            .UseEntityFrameworkCore()
            .UseDbContext<BlogDbContext>()
            .ReplaceDefaultEntities<Guid>();
    })
    .AddServer(options =>
    {
        options
            .SetAuthorizationEndpointUris("connect/authorize")
            .SetTokenEndpointUris("/connect/token")
            .SetLogoutEndpointUris("/connect/logout");

        options.AllowAuthorizationCodeFlow();
        
        options
            .AddDevelopmentEncryptionCertificate()
            .AddDevelopmentSigningCertificate();

        options
            .UseAspNetCore();
    });

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();