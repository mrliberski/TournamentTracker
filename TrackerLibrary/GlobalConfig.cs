using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv"; //private const - value will never chnage
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MAtchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";


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
                SqlConnector sql = new(); //SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
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
