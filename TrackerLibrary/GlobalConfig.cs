using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection? Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            //switch (db)
            //{
            //    case DatabaseType.Sql:
            //        break;
            //    case DatabaseType.TextFile:
            //        break;
            //    default:
            //        break;
            //}

            if (db == DatabaseType.Sql)
            {
                // TODO - set up the SQL connector
                SqlConnector sql = new(); //SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            if (db == DatabaseType.TextFile)
            {
                // TODO - if textfile
                TextConnector text = new();
                Connection = text;

            }
        }

        public static string CnnSting(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
