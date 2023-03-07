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
        public CreateTeamForm()
        {
            InitializeComponent();
        }

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
