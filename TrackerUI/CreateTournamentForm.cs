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
    public partial class CreateTournamentForm : Form, IPrizeRequestor, ITeamRequester
    {
        /// <summary>
        /// Pull the list of available teams
        /// </summary>
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            // null will allow correct refreshing of content of the lists
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName"; ;

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListbox.DataSource = null;
            prizesListbox.DataSource = selectedPrizes;
            prizesListbox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call create Prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // gets info back from form a prizeModel
            // take prize model, put into list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListbox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void removeSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListbox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("you need to enter a valid entry fee",
                    "Invalid fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // this stops exzec
            }

            // create tournament model
            TournamentModel tm = new();
            tm.TournamentName = TounamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // create and wire up our matchups
            // TODO - matchups
            // order list of teams randomly 
            // check if list is big enough - if not, add in byes (we need 2*2*2*2*2 = 2^4 = 16 teams)
            // create our first round of matchups
            // create every round after that - 8 matchups / 4 matchups / 2 matchups / 1 matchup
            TournamentLogic.CreateRounds(tm);

            // Create tournament entry an make it active
            // Create all of prizes entries 
            // create team entries
            GlobalConfig.Connection.CreateTournament(tm);



        }

        private void selectTeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
