namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            selectTeamMemberLabel = new Label();
            selectTeamMemberDropdown = new ComboBox();
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addMemberButton = new Button();
            addNewMemberBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneValue = new TextBox();
            cellPhoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListbox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.ImeMode = ImeMode.NoControl;
            selectTeamMemberLabel.Location = new Point(12, 159);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(277, 38);
            selectTeamMemberLabel.TabIndex = 19;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberDropdown.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(13, 200);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(307, 53);
            selectTeamMemberDropdown.TabIndex = 18;
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(13, 102);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(306, 43);
            teamNameValue.TabIndex = 17;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.ImeMode = ImeMode.NoControl;
            teamNameLabel.Location = new Point(13, 61);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(159, 38);
            teamNameLabel.TabIndex = 16;
            teamNameLabel.Text = "Team name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.ImeMode = ImeMode.NoControl;
            createTeamLabel.Location = new Point(12, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(198, 45);
            createTeamLabel.TabIndex = 15;
            createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.CornflowerBlue;
            addMemberButton.ImeMode = ImeMode.NoControl;
            addMemberButton.Location = new Point(88, 296);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(306, 60);
            addMemberButton.TabIndex = 25;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberButton);
            addNewMemberBox.Controls.Add(cellPhoneValue);
            addNewMemberBox.Controls.Add(cellPhoneLabel);
            addNewMemberBox.Controls.Add(emailValue);
            addNewMemberBox.Controls.Add(emailLabel);
            addNewMemberBox.Controls.Add(lastNameValue);
            addNewMemberBox.Controls.Add(lastNameLabel);
            addNewMemberBox.Controls.Add(firstNameValue);
            addNewMemberBox.Controls.Add(firstNameLabel);
            addNewMemberBox.ForeColor = SystemColors.MenuHighlight;
            addNewMemberBox.Location = new Point(13, 381);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new Size(465, 347);
            addNewMemberBox.TabIndex = 26;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "add new member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.CornflowerBlue;
            createMemberButton.ImeMode = ImeMode.NoControl;
            createMemberButton.Location = new Point(75, 259);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(306, 60);
            createMemberButton.TabIndex = 27;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(171, 200);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(242, 43);
            cellPhoneValue.TabIndex = 16;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellPhoneLabel.ImeMode = ImeMode.NoControl;
            cellPhoneLabel.Location = new Point(14, 205);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(96, 38);
            cellPhoneLabel.TabIndex = 15;
            cellPhoneLabel.Text = "Phone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(171, 151);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(242, 43);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.ImeMode = ImeMode.NoControl;
            emailLabel.Location = new Point(14, 156);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(83, 38);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(171, 102);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(242, 43);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.ImeMode = ImeMode.NoControl;
            lastNameLabel.Location = new Point(14, 107);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(147, 38);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(171, 53);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(242, 43);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.ImeMode = ImeMode.NoControl;
            firstNameLabel.Location = new Point(14, 58);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(151, 38);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListbox
            // 
            teamMembersListbox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersListbox.FormattingEnabled = true;
            teamMembersListbox.ItemHeight = 23;
            teamMembersListbox.Location = new Point(484, 38);
            teamMembersListbox.Name = "teamMembersListbox";
            teamMembersListbox.Size = new Size(425, 692);
            teamMembersListbox.TabIndex = 27;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedMemberButton.ForeColor = Color.CornflowerBlue;
            deleteSelectedMemberButton.ImeMode = ImeMode.NoControl;
            deleteSelectedMemberButton.Location = new Point(929, 345);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(233, 60);
            deleteSelectedMemberButton.TabIndex = 28;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.CornflowerBlue;
            createTeamButton.ImeMode = ImeMode.NoControl;
            createTeamButton.Location = new Point(393, 736);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(395, 60);
            createTeamButton.TabIndex = 29;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 822);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListbox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectTeamMemberLabel;
        private ComboBox selectTeamMemberDropdown;
        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addMemberButton;
        private GroupBox addNewMemberBox;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListbox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}