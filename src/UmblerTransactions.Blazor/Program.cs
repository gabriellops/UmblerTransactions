using CurrieTechnologies.Razor.SweetAlert2;
using UmblerTransactions.Blazor.Components;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Interfaces.Services;
using UmblerTransactions.Domain.Services;
using UmblerTransactions.Domain.Settings;
using UmblerTransactions.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSweetAlert2();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

var appSetting = builder.Configuration.GetSection(nameof(AppSetting)).Get<AppSetting>();
builder.Services.AddSingleton(appSetting);

builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ICaptureService, CaptureService>();
builder.Services.AddScoped<ICancellationService, CancellationService>();

#region HttpClient

builder.Services.AddHttpClient<ITransactionRepository, TransactionRepository>(options => {
    options.BaseAddress = new Uri(appSetting.ApiCielo);
});

builder.Services.AddHttpClient<ICaptureRepository, CaptureRepository>(options => {
    options.BaseAddress = new Uri(appSetting.ApiCielo);
});

builder.Services.AddHttpClient<ICancellationRepository, CancellationRepository>(options => {
    options.BaseAddress = new Uri(appSetting.ApiCielo);
});
#endregion

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
