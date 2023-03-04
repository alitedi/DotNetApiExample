using Serilog;

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

// Serolig Configuration 
builder.Host.UseSerilog((context, loggerConfiguration) => {
    // context : instance of builder 

    // 1. Can write on console 
    // 2. access to configuration file (appsettings.json) 
    loggerConfiguration.WriteTo.Console().ReadFrom.Configuration(context.Configuration);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Start logging the type of requests coming in like HTTP Get / reponse etc... 
app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
