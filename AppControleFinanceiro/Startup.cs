using AppControleFinanceiro.Repositories;
using LiteDB;

namespace AppControleFinanceiro;

public static class Startup
{
    public static MauiAppBuilder RegisterServicesAndRepositories(this MauiAppBuilder mauiAppBuilder)
    {
        // Instancia banco de dados LiteDB
        mauiAppBuilder.Services.AddSingleton<LiteDatabase>(options =>
            new LiteDatabase($"Filename={AppSettings.DataBasePath}"));
        
        //Services e Repositories
        mauiAppBuilder.Services.AddTransient<ITransactionRepositorie, TransactionRepositorie>();

        return mauiAppBuilder;
    }
}