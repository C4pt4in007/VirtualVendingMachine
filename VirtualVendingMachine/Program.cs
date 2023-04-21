using VirtualVendingMachine.Controllers;
using VirtualVendingMachine.Repository;
using VirtualVendingMachine.Service;
using VirtualVendingMachine.Service.CancelPurchaseService;
using VirtualVendingMachine.Service.InsertMoneyService;
using VirtualVendingMachine.Service.MoneyTypeService;
using VirtualVendingMachine.Service.ProductDetailsService;
using VirtualVendingMachine.Service.PurchaseService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductDetailsService, ProductDetailsService>();
builder.Services.AddScoped<IInsertMoneyService, InsertMoneyService>();
builder.Services.AddScoped<IMoneyTypeService, MoneyTypeService>();
builder.Services.AddScoped<ICancelPurchaseService, CancelPurchaseService>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IProductDetailsRespository, ProductDetailsRepository>();
builder.Services.AddScoped<TemporaryTransactionStorage>();
builder.Services.AddScoped<VendingMachineStorage>();
builder.Services.AddScoped<TemporaryMoneyService>();

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
