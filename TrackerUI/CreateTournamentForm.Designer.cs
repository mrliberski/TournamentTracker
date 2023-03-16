namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TounamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListbox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLAbel = new System.Windows.Forms.Label();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrize = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListbox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(14, 9);
            this.CreateTournamentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(296, 45);
            this.CreateTournamentLabel.TabIndex = 3;
            this.CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TounamentNameValue
            // 
            this.TounamentNameValue.Location = new System.Drawing.Point(14, 106);
            this.TounamentNameValue.Margin = new System.Windows.Forms.Padding(5);
            this.TounamentNameValue.Name = "TounamentNameValue";
            this.TounamentNameValue.Size = new System.Drawing.Size(296, 43);
            this.TounamentNameValue.TabIndex = 15;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TournamentNameLabel.Location = new System.Drawing.Point(14, 63);
            this.TournamentNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.TournamentNameLabel.TabIndex = 14;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(206, 159);
            this.EntryFeeValue.Margin = new System.Windows.Forms.Padding(5);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(104, 43);
            this.EntryFeeValue.TabIndex = 18;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntryFeeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EntryFeeLabel.Location = new System.Drawing.Point(14, 154);
            this.EntryFeeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(132, 38);
            this.EntryFeeLabel.TabIndex = 17;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectTeamLabel.Location = new System.Drawing.Point(14, 217);
            this.SelectTeamLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.SelectTeamLabel.TabIndex = 20;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamDropdown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(14, 258);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(297, 53);
            this.selectTeamDropdown.TabIndex = 21;
            // 
            // createNewTeamLabel
            // 
            this.createNewTeamLabel.AutoSize = true;
            this.createNewTeamLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLabel.Location = new System.Drawing.Point(14, 314);
            this.createNewTeamLabel.Name = "createNewTeamLabel";
            this.createNewTeamLabel.Size = new System.Drawing.Size(144, 23);
            this.createNewTeamLabel.TabIndex = 22;
            this.createNewTeamLabel.TabStop = true;
            this.createNewTeamLabel.Text = "Create New Team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addTeamButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addTeamButton.Location = new System.Drawing.Point(14, 375);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(296, 60);
            this.addTeamButton.TabIndex = 26;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createPrizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createPrizeButton.Location = new System.Drawing.Point(15, 451);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(296, 60);
            this.createPrizeButton.TabIndex = 27;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListbox
            // 
            this.tournamentPlayersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersListbox.FormattingEnabled = true;
            this.tournamentPlayersListbox.ItemHeight = 23;
            this.tournamentPlayersListbox.Location = new System.Drawing.Point(416, 106);
            this.tournamentPlayersListbox.Name = "tournamentPlayersListbox";
            this.tournamentPlayersListbox.Size = new System.Drawing.Size(300, 163);
            this.tournamentPlayersListbox.TabIndex = 28;
            // 
            // tournamentPlayersLAbel
            // 
            this.tournamentPlayersLAbel.AutoSize = true;
            this.tournamentPlayersLAbel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentPlayersLAbel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tournamentPlayersLAbel.Location = new System.Drawing.Point(416, 63);
            this.tournamentPlayersLAbel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tournamentPlayersLAbel.Name = "tournamentPlayersLAbel";
            this.tournamentPlayersLAbel.Size = new System.Drawing.Size(261, 38);
            this.tournamentPlayersLAbel.TabIndex = 29;
            this.tournamentPlayersLAbel.Text = "Tournament Players";
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedTeamButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(773, 124);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(198, 145);
            this.deleteSelectedTeamButton.TabIndex = 30;
            this.deleteSelectedTeamButton.Text = "Delete Selected";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrize
            // 
            this.deleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrize.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedPrize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteSelectedPrize.Location = new System.Drawing.Point(773, 389);
            this.deleteSelectedPrize.Name = "deleteSelectedPrize";
            this.deleteSelectedPrize.Size = new System.Drawing.Size(198, 122);
            this.deleteSelectedPrize.TabIndex = 33;
            this.deleteSelectedPrize.Text = "Delete Selected";
            this.deleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prizesLabel.Location = new System.Drawing.Point(416, 305);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(90, 38);
            this.prizesLabel.TabIndex = 32;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListbox
            // 
            this.prizesListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesListbox.FormattingEnabled = true;
            this.prizesListbox.ItemHeight = 23;
            this.prizesListbox.Location = new System.Drawing.Point(416, 348);
            this.prizesListbox.Name = "prizesListbox";
            this.prizesListbox.Size = new System.Drawing.Size(300, 163);
            this.prizesListbox.TabIndex = 31;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTournamentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTournamentButton.Location = new System.Drawing.Point(381, 571);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(296, 60);
            this.createTournamentButton.TabIndex = 34;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 727);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrize);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListbox);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.tournamentPlayersLAbel);
            this.Controls.Add(this.tournamentPlayersListbox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLabel);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TounamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create  Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PlaceNumberLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label CreateTournamentLabel;
        private TextBox TounamentNameValue;
        private Label TournamentNameLabel;
        private TextBox EntryFeeValue;
        private Label EntryFeeLabel;
        private Label SelectTeamLabel;
        private ComboBox selectTeamDropdown;
        private LinkLabel createNewTeamLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListbox;
        private Label tournamentPlayersLAbel;
        private Button deleteSelectedTeamButton;
        private Button deleteSelectedPrize;
        private Label prizesLabel;
        private ListBox prizesListbox;
        private Button createTournamentButton;
    }
}