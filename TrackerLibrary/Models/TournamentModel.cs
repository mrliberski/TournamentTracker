﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent a tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Unique name for a single tournament
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// Defines an entry fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The set of teams that have been entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes for the various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel> ();

        /// <summary>
        /// MAtchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>> ();
    }
}
