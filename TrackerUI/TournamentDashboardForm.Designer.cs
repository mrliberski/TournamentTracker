namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingtournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentDashboardLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(12, 9);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(372, 46);
            this.tournamentDashboardLabel.TabIndex = 1;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingtournamentLabel
            // 
            this.loadExistingtournamentLabel.AutoSize = true;
            this.loadExistingtournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadExistingtournamentLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loadExistingtournamentLabel.Location = new System.Drawing.Point(12, 88);
            this.loadExistingtournamentLabel.Name = "loadExistingtournamentLabel";
            this.loadExistingtournamentLabel.Size = new System.Drawing.Size(334, 38);
            this.loadExistingtournamentLabel.TabIndex = 5;
            this.loadExistingtournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropdown
            // 
            this.loadExistingTournamentDropdown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentDropdown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadExistingTournamentDropdown.FormattingEnabled = true;
            this.loadExistingTournamentDropdown.Location = new System.Drawing.Point(12, 129);
            this.loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            this.loadExistingTournamentDropdown.Size = new System.Drawing.Size(372, 53);
            this.loadExistingTournamentDropdown.TabIndex = 4;
            this.loadExistingTournamentDropdown.SelectedIndexChanged += new System.EventHandler(this.loadExistingTournamentDropdown_SelectedIndexChanged);
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loadTournamentButton.Location = new System.Drawing.Point(12, 197);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(372, 56);
            this.loadTournamentButton.TabIndex = 14;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTournamentButton.Location = new System.Drawing.Point(12, 507);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(372, 56);
            this.createTournamentButton.TabIndex = 15;
            this.createTournamentButton.Text = "Craete Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 590);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingtournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropdown);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label loadExistingtournamentLabel;
        private ComboBox loadExistingTournamentDropdown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}