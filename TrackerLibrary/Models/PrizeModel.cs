using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Defines the prize for winnign a tournament
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// id of the entry in database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// PLace number like 1, 2, 3
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Place Name ie first second third etc
        /// </summary>
        public string? PlaceName { get; set; }

        /// <summary>
        /// Fixed amount this place earns or zero if it;s not used
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Percentage of the prize that can be won 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
