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
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAnyPolicy",
        policyBuilder => policyBuilder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
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
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseCors("AllowAnyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();