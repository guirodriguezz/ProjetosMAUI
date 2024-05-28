namespace AppControleFinanceiro;

public class AppSettings
{
    private static readonly string DataBaseName = "database.db";
    private static readonly string DataBaseDirectory = FileSystem.AppDataDirectory;
    public static readonly string DataBasePath = Path.Combine(DataBaseName, DataBaseDirectory);
}