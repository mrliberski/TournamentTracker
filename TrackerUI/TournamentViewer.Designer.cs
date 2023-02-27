namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            resources.ApplyResources(this.headerLabel, "headerLabel");
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Name = "headerLabel";
            // 
            // tournamentName
            // 
            resources.ApplyResources(this.tournamentName, "tournamentName");
            this.tournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentName.Name = "tournamentName";
            // 
            // roundDropdown
            // 
            resources.ApplyResources(this.roundDropdown, "roundDropdown");
            this.roundDropdown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // roundLabel
            // 
            resources.ApplyResources(this.roundLabel, "roundLabel");
            this.roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // unplayedOnlyCheckbox
            // 
            resources.ApplyResources(this.unplayedOnlyCheckbox, "unplayedOnlyCheckbox");
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            this.matchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.matchupListbox, "matchupListbox");
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.Name = "matchupListbox";
            // 
            // teamOneNameLabel
            // 
            resources.ApplyResources(this.teamOneNameLabel, "teamOneNameLabel");
            this.teamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            // 
            // teamOneScoreLabel
            // 
            resources.ApplyResources(this.teamOneScoreLabel, "teamOneScoreLabel");
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            // 
            // teamOneScoreValue
            // 
            resources.ApplyResources(this.teamOneScoreValue, "teamOneScoreValue");
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            // 
            // teamTwoLabel
            // 
            resources.ApplyResources(this.teamTwoLabel, "teamTwoLabel");
            this.teamTwoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoLabel.Name = "teamTwoLabel";
            // 
            // teamTwoScoreValue
            // 
            resources.ApplyResources(this.teamTwoScoreValue, "teamTwoScoreValue");
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            // 
            // teamTwoScoreLabel
            // 
            resources.ApplyResources(this.teamTwoScoreLabel, "teamTwoScoreLabel");
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            // 
            // versusLabel
            // 
            resources.ApplyResources(this.versusLabel, "versusLabel");
            this.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versusLabel.Name = "versusLabel";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.scoreButton, "scoreButton");
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Name = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private ComboBox roundDropdown;
        private Label roundLabel;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListbox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private Label teamTwoLabel;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}