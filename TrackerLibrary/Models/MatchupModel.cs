﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in a tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// id of the entry in database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in a tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel? Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
