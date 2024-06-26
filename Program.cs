using Microsoft.EntityFrameworkCore;
using BookApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.PropertyNamingPolicy = null);
//builder.Services.AddDbContext<BookDbContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
//builder.Services.AddDbContext<BookDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddDbContext<BookDbContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("SQLite")));
builder.Services.AddCors(o =>
{
    o.AddPolicy(name: "_myAllowSpecificOrigins",
                        b =>
                        {
                            b.WithOrigins("http://localhost:5100")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("_myAllowSpecificOrigins");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
