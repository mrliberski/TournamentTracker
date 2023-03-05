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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                // Save data 
                GlobalConfig.Connection.CreatePrize(model);

                // Clear form
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information :(", "Please check information...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        // Form validation block 
        private bool ValidateForm()
        {
            // TODO - think of how to communicate errors back to user
            // set output to true and if if fails along the way it will be reset to false
            bool output = true;

            // Parse place number to int
            int placeNumber = 0;
            bool placeNumberValidNumber = (int.TryParse(placeNumberValue.Text, out placeNumber));
            // Check if this succeded
            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmounntVAlid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizaePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmounntVAlid || !prizaePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
