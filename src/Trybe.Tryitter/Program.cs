using Trybe.Tryitter.Repository;

var builder = WebApplication.CreateBuilder(args);

using (var db = new MyContext())
{
    db.Database.EnsureCreated();
}

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MyContext>();
builder.Services.AddScoped<IMyContext, MyContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();