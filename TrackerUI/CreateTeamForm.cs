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
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            // Adding sample data - to be removed later when not needed
            // CreateSampleData();

            // Call wire up method
            WireUpLists();
        }

        /// <summary>
        /// just fake data for testing
        /// </summary>
        private void CreateSampleData() 
        {
            availableTeamMembers.Add(new PersonModel { FirstName="Pawel" , LastName = "Liberski" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Malgosia", LastName = "Liberski" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Anthony", LastName = "Liberski" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Emily", LastName = "Liberski" });
        }

        /// <summary>
        /// populating drop down and list
        /// </summary>
        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListbox.DataSource = selectedTeamMembers;
            teamMembersListbox.DisplayMember = "FullName";
        }

        // Create Member button click event
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel();
                person.FirstName = firstNameValue.Text; 
                person.LastName = lastNameValue.Text;
                person.EmailAddress = emailValue.Text;
                person.CellPhoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(person);

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

            if (lastNameValue.Text.Length == 0){ output = false; }
            if (emailValue.Text.Length == 0) {  output = false; }
            if (cellPhoneValue.Text.Length == 0) { output = false; }

            return output;
        }

    }
}
