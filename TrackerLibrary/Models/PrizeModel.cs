namespace TrackerLibrary.Models
{
    /// <summary>Defines the prize for winnign a tournament
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

        /// <summary>
        /// Default struct
        /// </summary>
        public PrizeModel()
        {

        }

        /// <summary>
        /// Struct which will handle parsing of string values forom the form and will transform into relevant data types
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            // intellisense says assignment is unnecessary but i believe it is required so I am choosing to ignore it
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
