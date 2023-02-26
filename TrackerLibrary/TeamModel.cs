using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a team in a tournament
    /// </summary>
    public class TeamModel
    {
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
