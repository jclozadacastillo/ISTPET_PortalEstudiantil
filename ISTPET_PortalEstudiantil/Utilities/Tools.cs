using MySql.Data.MySqlClient;
using System.Data;

namespace ISTPET_PortalEstudiantil.Utilities
{
    public static class Tools
    {
        public static IConfiguration? config;
        public static string? rootPath;

        public static void Initialize(IConfiguration Configuration, string _host)
        {
            config = Configuration!;
            rootPath = _host!;
        }

        public static void logError(Exception _error)
        {
            try
            {
                var path = $@"{rootPath}/_errors.txt";
                if (!File.Exists(path))
                {
                    using (var sw = new StreamWriter(path, true))
                    {
                        sw.WriteLine($"{DateTime.Now} - Error: {_error.Message}  - Source: {_error.StackTrace}");
                    }
                }
                else
                {
                    File.AppendAllLines(path, new[] { $"{DateTime.Now} - Error: {_error.Message} - Source: {_error.StackTrace}" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
