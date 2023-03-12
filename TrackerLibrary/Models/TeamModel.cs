using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a team in a tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Id of the record we eill be getting from db
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The list of members of a team 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The unique name of a team 
        /// </summary>
        public string? TeamName { get; set; }

    }
}
