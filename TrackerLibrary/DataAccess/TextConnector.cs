using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Drawing.Text;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // filenames we'll be sevaing stuff into
        private const string PrizesFile = "PrizeModels.csv"; //private const - value will never chnage
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MAtchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The price information, including unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load text file and convert text to a alist of prizemodel
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find id
            int currentId = 1;

            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
  
            model.Id = currentId;

            // add new record with new id (max +1)
            prizes.Add(model);


            // convert prixes to a list of string
            // save a list of string to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            // Load file and convert it to model
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            // find id
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;

        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PeopleFile, PrizesFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            // Load file and convert it to model
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

    }
}