using Microsoft.Identity.Web;
using TGC.StarRealming.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication()
	.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAdB2C"));

builder.Services.AddAuthorization(options =>
{
	options.FallbackPolicy = options.DefaultPolicy;
});
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
