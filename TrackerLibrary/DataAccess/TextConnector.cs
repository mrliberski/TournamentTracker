using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Drawing.Text;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv"; //private const - value will never chnage
        private const string PeopleFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count >0)
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
    }
}
