var builder = WebApplication.CreateBuilder(args);

var service = builder.Services;
var config = builder.Configuration;

service.AddEndpointsApiExplorer();
service.AddSwaggerGen();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();