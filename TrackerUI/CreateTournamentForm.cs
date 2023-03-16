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
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        readonly List<TeamModel> selectedTeams = new();
        readonly List<PrizeModel> selectedPrizes = new();

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

            // get back from form a prizeModel


            // take prize model, put into list of selected prizes
        }

        public void PrizeComplete(PrizeModel model)
        {
            // get back from form a prizeModel
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
            PrizeModel p =(PrizeModel)prizesListbox.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();

            }
        }
    }
}
