using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using TrackerLibrary.Models;

// *load text file
// *convert text to a alist of prizemodel
// find id
// add new record with new id (max +1)
// convert prixes to a list of string
// save a list of string to text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TexConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //prizeModels.csv
        {
            // Define full path of the file basing on config directory and filename taken as an argument
            // "C:\Users\panli\OneDrive\Desktop\Sharpies\Tournament\TournamentTracker"
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}"; // points to App.config settings key
        }

        // 1. load text file
        public static List<string> LoadFile(this string file)
        {
            //check if file exist
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        // 2. convert text from csv.file to a list of prizemodel
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        // 2. convert text from csv.file to a list of personmodel
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }


        // 3. find id
        // 4. add new record with new id (max +1)

        // 5. convert prices to a list of string
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            // 6. save a list of string to text file
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id, teamname, list of id separated by pipe
            // 3, Tim's Team, 1|3|4

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel team = new TeamModel();
                team.Id = int.Parse(cols[0]);
                team.TeamName = cols[1];

                //spliting by pipe
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    // take list people in txtt file and filter where id of person is the one passed in; find first id (only one anyway)
                    // will crash on First() method if list is empty 
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }


                //add team to output
                output.Add(team);
            }

            return output;

        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines,
            string teamFileName,
            string peopleNameFile,
            string prizesFileName)
        {
            // id, TournamentName,EntryFee, (EnteredTeams - id|id|id), (Prizes - id|id|id), (Rounds - id^id^id^|id^id^id^|id^id^id^)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleNameFile);
            List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                // TODO - CAPTURE ROUNDS INFORMATION

                output.Add(tm);
            }

            return output;
        }


        /// <summary>
        /// Saves Team to team file
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel model in models)
            {
                lines.Add($"{model.Id},{model.TeamName},{ConvertPeopleListToString(model.TeamMembers)}");
                File.WriteAllLines(fileName.FullFilePath(), lines);
            }
        }

        /// <summary>
        /// Method thet saves a tournament to tournament file, takes filename as an argument
        /// </summary>
        /// <param name="models">Takes List of tournament models</param>
        /// <param name="fileName">Takes tournament filename (static value) </param>
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($@"{tm.Id},
                    {tm.TournamentName},
                    {tm.EntryFee},
                    {ConvertTeamlistToString(tm.EnteredTeams)},
                    {ConvertPrizelistToString(tm.Prizes)},
                    {ConvertRoundlistToString(tm.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string MatchupFile, string MatchupEntryFile)
        {
            // loop through each round
            //loop through each matchup
            //get id fore new matchup an save
            //loop through entry, get id and save it

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    // Load all of the matchups from File
                    // Get the topi id and add one
                    // store th eid
                    // save matchup record
                    matchup.SaveMatchupToFile(MatchupFile, MatchupEntryFile);


                }
            }
        }

        private static TeamModel LookupTeamById (int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PeopleFile);
            return teams.Where(x => x.Id == id).First();
        }

        private static List<MatchupEntryModel>ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            foreach (string id in ids)
            {

                output.Add(entries.Where(x => x.Id == int.Parse(id)).First());
            }

            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels (this List<string> lines)
        {
            //id=0, teamcompeting=1, score=2, parentmatchup=3
            List<MatchupEntryModel> output = new List<MatchupEntryModel> ();

            foreach (string line in lines)
            {
                string[]cols = line.Split(",");

                MatchupEntryModel me = new MatchupEntryModel ();
                me.Id = int.Parse(cols[0]);
                me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                me.Score = int.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(int.Parse(cols[3]));
                }
                else
                {
                    me.ParentMatchup = null;
                }

                output.Add(me);
            }

            return output;
  
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            return matchups.Where(x=> x.Id ==id).First();
        }

        public static List<MatchupModel>ConvertToMatchupModels(this List<string> lines)
        {
            //id=0, entries=1(pipe delimited byid), winner = 2, matchupround =3
            List<MatchupModel>output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                p.Winner = LookupTeamById(int.Parse(cols[2]));
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);

            }

            return output;
        }

        public static void SaveMatchupToFile(this MatchupModel matchup, string MatchupFile, string MatchupEntryFile) 
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(MatchupEntryFile);
            }
            // TODO - save to file
        }

        public static void SaveEntryToFile( this MatchupEntryModel entry, string MatchupEntryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;

            //TODO - save to file
        }

        private static string ConvertRoundlistToString(List<List<MatchupModel>> rounds)
        {
            //( id^id^id|id^id^id|id^id^id)

            string output = string.Empty;

            if (rounds.Count == 0)
            {
                // if list of people is empty, program will crash hence escape
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                // below will retur string with pipe at the end so we will remove it after looping
                output += $"{ConvertMatchupListToString(r)}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = string.Empty;
            if (matchups.Count == 0)
            {
                // if list of people is empty, program will crash hence escape
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                // below will retur string with pipe at the end so we will remove it after looping
                output += $"{m.Id}^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPrizelistToString(List<PrizeModel> prizes)
        {
            string output = string.Empty;

            if (prizes.Count == 0)
            {
                // if list of people is empty, program will crash hence escape
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                // below will retur string with pipe at the end so we will remove it after looping
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        /// <summary>
        /// helper method for SaveToTournamentFile method
        /// </summary>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static string ConvertTeamlistToString(List<TeamModel> teams)
        {
            string output = string.Empty;

            if (teams.Count == 0)
            {
                // if list of people is empty, program will crash hence escape
                return "";
            }

            foreach (TeamModel t in teams)
            {
                // below will retur string with pipe at the end so we will remove it after looping
                output += $"{t.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        /// <summary>
        /// Helper method for the method SavetoTeamFile
        /// </summary>
        /// <param name="people"></param>
        /// <returns>changes list of list of personModel into single string</returns>
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = string.Empty;

            
            if (people.Count ==0)
            {
                // if list of people is empty, program will crash hence escape
                return "";
            }

            foreach (PersonModel person in people)
            {
                // below will retur string with pipe at the end so we will remove it after looping
                output += $"{person.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;

        }


    }
}
