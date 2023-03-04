namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            CreatePrizeLabel = new Label();
            placeNumberValue = new TextBox();
            PlaceNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePertcentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeLabel.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeLabel.ImeMode = ImeMode.NoControl;
            CreatePrizeLabel.Location = new Point(20, 14);
            CreatePrizeLabel.Margin = new Padding(5, 0, 5, 0);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(191, 45);
            CreatePrizeLabel.TabIndex = 2;
            CreatePrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(224, 98);
            placeNumberValue.Margin = new Padding(5);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(222, 43);
            placeNumberValue.TabIndex = 12;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNumberLabel.ImeMode = ImeMode.NoControl;
            PlaceNumberLabel.Location = new Point(30, 98);
            PlaceNumberLabel.Margin = new Padding(5, 0, 5, 0);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(192, 38);
            PlaceNumberLabel.TabIndex = 11;
            PlaceNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(224, 151);
            placeNameValue.Margin = new Padding(5);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(222, 43);
            placeNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.ImeMode = ImeMode.NoControl;
            placeNameLabel.Location = new Point(30, 151);
            placeNameLabel.Margin = new Padding(5, 0, 5, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(164, 38);
            placeNameLabel.TabIndex = 13;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(224, 204);
            prizeAmountValue.Margin = new Padding(5);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(222, 43);
            prizeAmountValue.TabIndex = 16;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.ImeMode = ImeMode.NoControl;
            prizeAmountLabel.Location = new Point(30, 204);
            prizeAmountLabel.Margin = new Padding(5, 0, 5, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(185, 38);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(224, 303);
            prizePercentageValue.Margin = new Padding(5);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(222, 43);
            prizePercentageValue.TabIndex = 18;
            // 
            // prizePertcentageLabel
            // 
            prizePertcentageLabel.AutoSize = true;
            prizePertcentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePertcentageLabel.ImeMode = ImeMode.NoControl;
            prizePertcentageLabel.Location = new Point(30, 303);
            prizePertcentageLabel.Margin = new Padding(5, 0, 5, 0);
            prizePertcentageLabel.Name = "prizePertcentageLabel";
            prizePertcentageLabel.Size = new Size(109, 38);
            prizePertcentageLabel.TabIndex = 17;
            prizePertcentageLabel.Text = "Prize %";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.ImeMode = ImeMode.NoControl;
            orLabel.Location = new Point(224, 260);
            orLabel.Margin = new Padding(5, 0, 5, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(81, 38);
            orLabel.TabIndex = 19;
            orLabel.Text = "- or -";
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
            createPrizeButton.Location = new Point(51, 392);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(395, 60);
            createPrizeButton.TabIndex = 25;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 507);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePertcentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel;
        private TextBox placeNumberValue;
        private Label PlaceNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePertcentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}