using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_project;

public class DatabaseSingleton
{
    private static SqlConnection conn = null;
    private DatabaseSingleton()
    {

    }
    public static SqlConnection GetInstance()
    {
        if (conn == null)
        {
            SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.InitialCatalog = ReadSetting("Database");
            consStringBuilder.DataSource = ReadSetting("DataSource");
            consStringBuilder.IntegratedSecurity = bool.Parse(ReadSetting("Integrated Security"));
            consStringBuilder.ConnectTimeout = 30;
            conn = new SqlConnection(consStringBuilder.ConnectionString);

            conn.Open();
        }
        return conn;
    }

    public static void CloseConnection()
    {
        try
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        catch { }
        finally
        {
            conn = null;
        }
    }

    private static string ReadSetting(string key)
    {
        //nutno doinstalovat, VS nabídne doinstalaci samo
        var appSettings = ConfigurationManager.AppSettings;
        string result = appSettings[key] ?? "Not Found";
        return result;
    }
}
