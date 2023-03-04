using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Defines the prize for winnign a tournament
    /// </summary>
    public class PrizeModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? PlaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage )
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse( placeNumber, out placeNumberValue);
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
