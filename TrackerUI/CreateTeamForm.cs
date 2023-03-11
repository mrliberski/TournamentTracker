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
    public partial class CreateTeamForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private readonly List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            // Adding sample data - to be removed later when not needed
            // CreateSampleData();

            WireUpLists();
        }

        /// <summary>
        /// just fake data for testing
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Pawel", LastName = "Liberski" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Malgosia", LastName = "Liberski" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Anthony", LastName = "Liberski" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Emily", LastName = "Liberski" });
        }

        /// <summary>
        /// populating drop down and list
        /// </summary>
        private void WireUpLists()
        {
            // null will allow correct refreshing of content of the lists
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListbox.DataSource = null;

            teamMembersListbox.DataSource = selectedTeamMembers;
            teamMembersListbox.DisplayMember = "FullName";


        }

        // Create Member button click event
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellPhoneValue.Text;
              
                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid member information :(", "Please check information...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        /// <summary>
        /// Validation of entries (could add more steps but perhaps at some later time)
        /// </summary>
        /// <returns>bool output - telling whether validation is successfull</returns>
        private bool ValidateForm()
        {
            bool output = true;

            // TODO - Add more validation to the form

            if (firstNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameValue.Text.Length == 0) { output = false; }
            if (emailValue.Text.Length == 0) { output = false; }
            if (cellPhoneValue.Text.Length == 0) { output = false; }

            return output;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // remove person from available team members list
            // add person to available team members list
            // refresh

            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists(); 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListbox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists(); 
            }
        }
    }
}
