using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// id of the entry in database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of a person
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of a person
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// The primary email address of the person
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The primary cell phone number of a person
        /// </summary>
        public string? CellPhoneNumber { get; set; }

        /// <summary>
        /// returns surname
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
