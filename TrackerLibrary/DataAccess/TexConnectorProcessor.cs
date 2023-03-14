using System.Configuration;
using System.Data.Common;
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
        public static List<PersonModel> ConvertToPersonModels (this List<string> lines)
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

            File.WriteAllLines (fileName.FullFilePath(), lines);
        }

        public static List<TeamModel>ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id, teamname, list of id separated by pipe
            // 3, Tim's Team, 1|3|4

            List<TeamModel>output = new List<TeamModel>();
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
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First() );
                }

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
            List<string> lines =new List<string>();

            foreach(TeamModel model in models)
            {
                lines.Add($"{ model.Id },{model.TeamName },{ ConvertPeopleListToString(model.TeamMembers) }");
                File.WriteAllLines(fileName.FullFilePath(), lines);
            }
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
