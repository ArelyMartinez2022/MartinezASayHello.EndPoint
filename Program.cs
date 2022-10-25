/*
ARELY MARTINEZ 
OCT 25 2022, 10:51 AM 
SAY HELLO END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT THIER NAME AND IT REPSOND 
GOOD MORNING THEN THIER NAME. THEY WOULD 
INPUT THROUGH POSTMAN LIKE 
OUTPUT: https://localhost:7119/input/HELLO/ARELY
OUTPUT: GOOD MORNING {ARELY}!!

PEER REVIEW: Maddie Gowan -- Runs as it should! 
I see no issues. It's written just as we were told 
to do it, and functions in postman
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
