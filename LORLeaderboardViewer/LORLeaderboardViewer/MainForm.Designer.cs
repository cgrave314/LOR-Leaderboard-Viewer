namespace LORLeaderboardViewer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegionBox = new System.Windows.Forms.ComboBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ApikeyLabel = new System.Windows.Forms.Label();
            this.APIKeyTextbox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.RankTextBox = new System.Windows.Forms.TextBox();
            this.LeaguePointsLabel = new System.Windows.Forms.Label();
            this.LeaguePointsTextBox = new System.Windows.Forms.TextBox();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.ViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RegionBox);
            this.groupBox1.Controls.Add(this.RunButton);
            this.groupBox1.Controls.Add(this.ApikeyLabel);
            this.groupBox1.Controls.Add(this.APIKeyTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Key and Region";
            // 
            // RegionBox
            // 
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Items.AddRange(new object[] {
            "",
            "AMERICAS",
            "ASIA",
            "EUROPE",
            "SEA"});
            this.RegionBox.Location = new System.Drawing.Point(79, 124);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(121, 21);
            this.RegionBox.TabIndex = 3;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(137, 201);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(123, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApikeyLabel
            // 
            this.ApikeyLabel.AutoSize = true;
            this.ApikeyLabel.Location = new System.Drawing.Point(22, 89);
            this.ApikeyLabel.Name = "ApikeyLabel";
            this.ApikeyLabel.Size = new System.Drawing.Size(51, 13);
            this.ApikeyLabel.TabIndex = 1;
            this.ApikeyLabel.Text = "API Key :";
            // 
            // APIKeyTextbox
            // 
            this.APIKeyTextbox.Location = new System.Drawing.Point(79, 86);
            this.APIKeyTextbox.Name = "APIKeyTextbox";
            this.APIKeyTextbox.Size = new System.Drawing.Size(266, 20);
            this.APIKeyTextbox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true));
            this.NameTextBox.Location = new System.Drawing.Point(486, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(273, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(422, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(422, 82);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(33, 13);
            this.RankLabel.TabIndex = 4;
            this.RankLabel.Text = "Rank";
            // 
            // RankTextBox
            // 
            this.RankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Rank", true));
            this.RankTextBox.Location = new System.Drawing.Point(486, 79);
            this.RankTextBox.Name = "RankTextBox";
            this.RankTextBox.Size = new System.Drawing.Size(273, 20);
            this.RankTextBox.TabIndex = 3;
            // 
            // LeaguePointsLabel
            // 
            this.LeaguePointsLabel.AutoSize = true;
            this.LeaguePointsLabel.Location = new System.Drawing.Point(405, 122);
            this.LeaguePointsLabel.Name = "LeaguePointsLabel";
            this.LeaguePointsLabel.Size = new System.Drawing.Size(75, 13);
            this.LeaguePointsLabel.TabIndex = 6;
            this.LeaguePointsLabel.Text = "League Points";
            // 
            // LeaguePointsTextBox
            // 
            this.LeaguePointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Lp", true));
            this.LeaguePointsTextBox.Location = new System.Drawing.Point(486, 119);
            this.LeaguePointsTextBox.Name = "LeaguePointsTextBox";
            this.LeaguePointsTextBox.Size = new System.Drawing.Size(273, 20);
            this.LeaguePointsTextBox.TabIndex = 5;
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayerListBox.DataSource = this.playersBindingSource;
            this.PlayerListBox.DisplayMember = "Name";
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(404, 174);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(384, 264);
            this.PlayerListBox.TabIndex = 7;
            this.PlayerListBox.ValueMember = "_AdditionalProperties";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = typeof(MingweiSamuel.Camille.LorRankedV1.Player);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Leaderboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Region :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerListBox);
            this.Controls.Add(this.LeaguePointsLabel);
            this.Controls.Add(this.LeaguePointsTextBox);
            this.Controls.Add(this.RankLabel);
            this.Controls.Add(this.RankTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "LOR Leaderboard Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ApikeyLabel;
        private System.Windows.Forms.TextBox APIKeyTextbox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.TextBox RankTextBox;
        private System.Windows.Forms.Label LeaguePointsLabel;
        private System.Windows.Forms.TextBox LeaguePointsTextBox;
        private System.Windows.Forms.ListBox PlayerListBox;
        private System.Windows.Forms.ComboBox RegionBox;
        private System.Windows.Forms.BindingSource ViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

