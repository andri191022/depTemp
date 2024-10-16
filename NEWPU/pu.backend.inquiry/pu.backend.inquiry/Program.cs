using Azure.Core;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using pu.backend.inquiry.Data;
using pu.backend.inquiry.Handlers;
using pu.backend.inquiry.Models.GPHEmail.Dto;
using pu.backend.inquiry.Queries;
using pu.backend.inquiry.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

// Add services to the container.

builder.Services.AddTransient<ResponseDto>();
builder.Services.AddTransient<IRequestHandler<GetXmlInquiryQuery, ResponseDto>, GetXmlInquiryHandler>();

builder.Services.AddMediatR(typeof(GetXmlInquiryQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetXmlInquiryHandler).GetTypeInfo().Assembly);

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddScoped<IGPHEmailRepository, GPHEmailRepository>();

//builder.Services.AddDbContext<EmailServiceDbContext>();


builder.Services.AddDbContext<EmailServiceDbContext>(options =>
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection cannot be found"),
    options => options.EnableRetryOnFailure(
        maxRetryCount: 2,
        maxRetryDelay: System.TimeSpan.FromSeconds(5),
        errorNumbersToAdd: null
        )
    )
);



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
