namespace CommandAliasing
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            UninstallButton = new Button();
            InstallButton = new Button();
            SaveButton = new Button();
            MacroView = new DataGridView();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MacroView).BeginInit();
            SuspendLayout();
            // 
            // UninstallButton
            // 
            UninstallButton.AutoSize = true;
            UninstallButton.BackColor = Color.FromArgb(191, 97, 106);
            UninstallButton.Dock = DockStyle.Bottom;
            UninstallButton.FlatAppearance.BorderSize = 0;
            UninstallButton.FlatStyle = FlatStyle.Flat;
            UninstallButton.ForeColor = Color.FromArgb(236, 239, 244);
            UninstallButton.Location = new Point(0, 535);
            UninstallButton.Margin = new Padding(5);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Size = new Size(446, 47);
            UninstallButton.TabIndex = 1;
            UninstallButton.Text = "Uninstall";
            UninstallButton.UseVisualStyleBackColor = false;
            UninstallButton.Click += UninstallButtonClick;
            // 
            // InstallButton
            // 
            InstallButton.AutoSize = true;
            InstallButton.BackColor = Color.FromArgb(163, 190, 140);
            InstallButton.Dock = DockStyle.Bottom;
            InstallButton.FlatAppearance.BorderColor = Color.WhiteSmoke;
            InstallButton.FlatAppearance.BorderSize = 0;
            InstallButton.FlatStyle = FlatStyle.Flat;
            InstallButton.ForeColor = Color.FromArgb(236, 239, 244);
            InstallButton.Location = new Point(0, 488);
            InstallButton.Margin = new Padding(5);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(446, 47);
            InstallButton.TabIndex = 0;
            InstallButton.Text = "Install";
            InstallButton.UseVisualStyleBackColor = false;
            InstallButton.Click += InstallButtonClick;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(94, 129, 172);
            SaveButton.Dock = DockStyle.Top;
            SaveButton.FlatAppearance.BorderColor = Color.WhiteSmoke;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.FromArgb(236, 239, 244);
            SaveButton.Location = new Point(0, 0);
            SaveButton.Margin = new Padding(10);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(446, 47);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButtonClick;
            // 
            // MacroView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 52, 64);
            MacroView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MacroView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MacroView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MacroView.BackgroundColor = Color.FromArgb(46, 52, 64);
            MacroView.BorderStyle = BorderStyle.None;
            MacroView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MacroView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MacroView.ColumnHeadersVisible = false;
            MacroView.EnableHeadersVisualStyles = false;
            MacroView.GridColor = Color.FromArgb(46, 52, 64);
            MacroView.Location = new Point(0, 93);
            MacroView.Name = "MacroView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 52, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MacroView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MacroView.RowHeadersVisible = false;
            MacroView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(46, 52, 64);
            MacroView.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(236, 239, 244);
            MacroView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(94, 129, 172);
            MacroView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(236, 239, 244);
            MacroView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MacroView.Size = new Size(446, 395);
            MacroView.TabIndex = 2;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(180, 142, 173);
            RefreshButton.Dock = DockStyle.Top;
            RefreshButton.FlatAppearance.BorderColor = Color.WhiteSmoke;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = Color.FromArgb(236, 239, 244);
            RefreshButton.Location = new Point(0, 47);
            RefreshButton.Margin = new Padding(10);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(446, 47);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButtonClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(446, 582);
            Controls.Add(RefreshButton);
            Controls.Add(SaveButton);
            Controls.Add(MacroView);
            Controls.Add(InstallButton);
            Controls.Add(UninstallButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "CommandAliasing - Azrael";
            ((System.ComponentModel.ISupportInitialize)MacroView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UninstallButton;
        private Button InstallButton;
        private Button SaveButton;
        private DataGridView MacroView;
        private Button RefreshButton;
    }
}
