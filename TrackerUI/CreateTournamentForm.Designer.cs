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
            CreateTournamentLabel = new Label();
            TounamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            EntryFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            SelectTeamLabel = new Label();
            selectTeamDropdown = new ComboBox();
            createNewTeamLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListbox = new ListBox();
            tournamentTeamsLabel = new Label();
            removeSelectedTeamButton = new Button();
            removeSelectedPrize = new Button();
            prizesLabel = new Label();
            prizesListbox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentLabel.ImeMode = ImeMode.NoControl;
            CreateTournamentLabel.Location = new Point(14, 9);
            CreateTournamentLabel.Margin = new Padding(5, 0, 5, 0);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(296, 45);
            CreateTournamentLabel.TabIndex = 3;
            CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TounamentNameValue
            // 
            TounamentNameValue.Location = new Point(14, 106);
            TounamentNameValue.Margin = new Padding(5);
            TounamentNameValue.Name = "TounamentNameValue";
            TounamentNameValue.Size = new Size(296, 43);
            TounamentNameValue.TabIndex = 15;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentNameLabel.ImeMode = ImeMode.NoControl;
            TournamentNameLabel.Location = new Point(14, 63);
            TournamentNameLabel.Margin = new Padding(5, 0, 5, 0);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(247, 38);
            TournamentNameLabel.TabIndex = 14;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            EntryFeeValue.Location = new Point(206, 159);
            EntryFeeValue.Margin = new Padding(5);
            EntryFeeValue.Name = "EntryFeeValue";
            EntryFeeValue.Size = new Size(104, 43);
            EntryFeeValue.TabIndex = 18;
            EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            EntryFeeLabel.ImeMode = ImeMode.NoControl;
            EntryFeeLabel.Location = new Point(14, 154);
            EntryFeeLabel.Margin = new Padding(5, 0, 5, 0);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(132, 38);
            EntryFeeLabel.TabIndex = 17;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            SelectTeamLabel.ImeMode = ImeMode.NoControl;
            SelectTeamLabel.Location = new Point(14, 217);
            SelectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(164, 38);
            SelectTeamLabel.TabIndex = 20;
            SelectTeamLabel.Text = "Select Team";
            SelectTeamLabel.Click += PlaceNumberLabel_Click;
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamDropdown.ForeColor = SystemColors.MenuHighlight;
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(14, 258);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(297, 53);
            selectTeamDropdown.TabIndex = 21;
            // 
            // createNewTeamLabel
            // 
            createNewTeamLabel.AutoSize = true;
            createNewTeamLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLabel.Location = new Point(14, 314);
            createNewTeamLabel.Name = "createNewTeamLabel";
            createNewTeamLabel.Size = new Size(144, 23);
            createNewTeamLabel.TabIndex = 22;
            createNewTeamLabel.TabStop = true;
            createNewTeamLabel.Text = "Create New Team";
            createNewTeamLabel.LinkClicked += createNewTeamLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.CornflowerBlue;
            addTeamButton.ImeMode = ImeMode.NoControl;
            addTeamButton.Location = new Point(14, 375);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(296, 60);
            addTeamButton.TabIndex = 26;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.CornflowerBlue;
            createPrizeButton.ImeMode = ImeMode.NoControl;
            createPrizeButton.Location = new Point(15, 451);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(296, 60);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListbox
            // 
            tournamentTeamsListbox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentTeamsListbox.FormattingEnabled = true;
            tournamentTeamsListbox.ItemHeight = 23;
            tournamentTeamsListbox.Location = new Point(416, 106);
            tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            tournamentTeamsListbox.Size = new Size(300, 163);
            tournamentTeamsListbox.TabIndex = 28;
            // 
            // tournamentTeamsLabel
            // 
            tournamentTeamsLabel.AutoSize = true;
            tournamentTeamsLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentTeamsLabel.ImeMode = ImeMode.NoControl;
            tournamentTeamsLabel.Location = new Point(416, 63);
            tournamentTeamsLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentTeamsLabel.Name = "tournamentTeamsLabel";
            tournamentTeamsLabel.Size = new Size(250, 38);
            tournamentTeamsLabel.TabIndex = 29;
            tournamentTeamsLabel.Text = "Tournament Teams";
            // 
            // removeSelectedTeamButton
            // 
            removeSelectedTeamButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedTeamButton.FlatStyle = FlatStyle.Flat;
            removeSelectedTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedTeamButton.ForeColor = Color.CornflowerBlue;
            removeSelectedTeamButton.ImeMode = ImeMode.NoControl;
            removeSelectedTeamButton.Location = new Point(773, 124);
            removeSelectedTeamButton.Name = "removeSelectedTeamButton";
            removeSelectedTeamButton.Size = new Size(198, 145);
            removeSelectedTeamButton.TabIndex = 30;
            removeSelectedTeamButton.Text = "Remove Selected";
            removeSelectedTeamButton.UseVisualStyleBackColor = true;
            removeSelectedTeamButton.Click += removeSelectedTeamButton_Click;
            // 
            // removeSelectedPrize
            // 
            removeSelectedPrize.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrize.FlatStyle = FlatStyle.Flat;
            removeSelectedPrize.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrize.ForeColor = Color.CornflowerBlue;
            removeSelectedPrize.ImeMode = ImeMode.NoControl;
            removeSelectedPrize.Location = new Point(773, 389);
            removeSelectedPrize.Name = "removeSelectedPrize";
            removeSelectedPrize.Size = new Size(198, 122);
            removeSelectedPrize.TabIndex = 33;
            removeSelectedPrize.Text = "Remove Selected";
            removeSelectedPrize.UseVisualStyleBackColor = true;
            removeSelectedPrize.Click += removeSelectedPrize_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.ImeMode = ImeMode.NoControl;
            prizesLabel.Location = new Point(416, 305);
            prizesLabel.Margin = new Padding(5, 0, 5, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(90, 38);
            prizesLabel.TabIndex = 32;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListbox
            // 
            prizesListbox.BorderStyle = BorderStyle.FixedSingle;
            prizesListbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListbox.FormattingEnabled = true;
            prizesListbox.ItemHeight = 23;
            prizesListbox.Location = new Point(416, 348);
            prizesListbox.Name = "prizesListbox";
            prizesListbox.Size = new Size(300, 163);
            prizesListbox.TabIndex = 31;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.CornflowerBlue;
            createTournamentButton.ImeMode = ImeMode.NoControl;
            createTournamentButton.Location = new Point(381, 571);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(296, 60);
            createTournamentButton.TabIndex = 34;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 727);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrize);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListbox);
            Controls.Add(removeSelectedTeamButton);
            Controls.Add(tournamentTeamsLabel);
            Controls.Add(tournamentTeamsListbox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLabel);
            Controls.Add(selectTeamDropdown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntryFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TounamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(CreateTournamentLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreateTournamentForm";
            Text = "Create  Tournament";
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox tournamentTeamsListbox;
        private Label tournamentTeamsLabel;
        private Button removeSelectedTeamButton;
        private Button removeSelectedPrize;
        private Label prizesLabel;
        private ListBox prizesListbox;
        private Button createTournamentButton;
    }
}