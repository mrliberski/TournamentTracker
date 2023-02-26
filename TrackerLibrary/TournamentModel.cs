﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent a tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel> ();

        /// <summary>
        /// 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>> ();
    }
}
