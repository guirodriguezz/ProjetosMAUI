using AppControleFinanceiro.Repositories;
using LiteDB;

namespace AppControleFinanceiro;

public static class Startup
{
    private static IServiceProvider? _serviceProvider;

    public static void ConfigureServices()
    {
        var services = new ServiceCollection();
        
        //Instancia banco de dados LiteDB
        services.AddSingleton<LiteDatabase>(options => new LiteDatabase($"Filename={AppSettings.DataBasePath}"));
        
        //Services e Repositories
        services.AddTransient<ITransactionRepositorie, TransactionRepositorie>();
        
        _serviceProvider = services.BuildServiceProvider();
    } 
    
    public static T? Resolve<T>()
    {
        return _serviceProvider!.GetService<T>();
    }
}