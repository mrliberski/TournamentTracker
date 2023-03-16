using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        /// <summary>
        /// Pull the list of available teams
        /// </summary>
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";
        }
    }
}
