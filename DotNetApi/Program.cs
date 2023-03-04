var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// CORS : Cross Origin Resource Sharing 
// Access to API throw out of server 
// From applications that are deployed to machines that are not on the same resource as our API. 
builder.Services.AddCors(options =>
{
    // Allow all to access to all the resources 
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyHeader()
                        .AllowAnyOrigin()
                        .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
