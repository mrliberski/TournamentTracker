using System.Configuration;
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

        // 2. convert text to a alist of prizemodel
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

        // 5. convert prixes to a list of string
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
                lines.Add($"{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines (fileName.FullFilePath(), lines);
        }



    }
}
