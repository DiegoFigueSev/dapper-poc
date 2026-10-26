using Microsoft.Data.Sqlite;

namespace DemoDapper.src.Database;
public static class DatabaseInit
{
    public static void Init(SqliteConnection connection)
    {
        var scriptPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "src",
            "Database",
            "Scripts"
        );

        var files = Directory.GetFiles(scriptPath, "*.sql").OrderBy(x => x);

        foreach (var file in files)
        {
            var sql = File.ReadAllText(file);
            using var command = connection.CreateCommand();

            command.CommandText = sql;

            command.ExecuteNonQuery();
        }
    }
}