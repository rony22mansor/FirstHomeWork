namespace FirstHomeWork
{
    partial class OptionsControl
    {
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel vStack;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel title;
        private System.Windows.Forms.Panel playerNamePanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlayerName;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerName;
        private System.Windows.Forms.Panel soundVolumePanel;
        private Guna.UI2.WinForms.Guna2TrackBar volumeTrackBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoundVolume;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.vStack = new System.Windows.Forms.TableLayoutPanel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.playerNamePanel = new System.Windows.Forms.Panel();
            this.lblPlayerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.soundVolumePanel = new System.Windows.Forms.Panel();
            this.lblSoundVolume = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.volumeTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.mainPanel.SuspendLayout();
            this.vStack.SuspendLayout();
            this.playerNamePanel.SuspendLayout();
            this.soundVolumePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.vStack);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(100, 200, 100, 200);
            this.mainPanel.Size = new System.Drawing.Size(1533, 834);
            this.mainPanel.TabIndex = 6;
            // 
            // vStack
            // 
            this.vStack.ColumnCount = 1;
            this.vStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vStack.Controls.Add(this.saveBtn, 0, 3);
            this.vStack.Controls.Add(this.title, 0, 0);
            this.vStack.Controls.Add(this.playerNamePanel, 0, 1);
            this.vStack.Controls.Add(this.soundVolumePanel, 0, 2);
            this.vStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vStack.Location = new System.Drawing.Point(100, 200);
            this.vStack.Margin = new System.Windows.Forms.Padding(0);
            this.vStack.Name = "vStack";
            this.vStack.RowCount = 4;
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.27189F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.1106F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.42396F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.vStack.Size = new System.Drawing.Size(1333, 434);
            this.vStack.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Animated = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderRadius = 16;
            this.saveBtn.BorderThickness = 5;
            this.saveBtn.DefaultAutoSize = true;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(500, 338);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(500, 10, 500, 25);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedDepth = 12;
            this.saveBtn.ShadowDecoration.BorderRadius = 16;
            this.saveBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saveBtn.ShadowDecoration.Depth = 60;
            this.saveBtn.ShadowDecoration.Enabled = true;
            this.saveBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.saveBtn.Size = new System.Drawing.Size(333, 71);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.saveBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.saveBtn.UseTransparentBackground = true;
            this.saveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // title
            // 
            this.title.AutoSize = false;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.IsContextMenuEnabled = false;
            this.title.IsSelectionEnabled = false;
            this.title.Location = new System.Drawing.Point(10, 10);
            this.title.Margin = new System.Windows.Forms.Padding(10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1313, 81);
            this.title.TabIndex = 10;
            this.title.Text = "Options";
            this.title.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerNamePanel
            // 
            this.playerNamePanel.Controls.Add(this.lblPlayerName);
            this.playerNamePanel.Controls.Add(this.txtPlayerName);
            this.playerNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNamePanel.Location = new System.Drawing.Point(500, 121);
            this.playerNamePanel.Margin = new System.Windows.Forms.Padding(500, 20, 500, 20);
            this.playerNamePanel.Name = "playerNamePanel";
            this.playerNamePanel.Padding = new System.Windows.Forms.Padding(2);
            this.playerNamePanel.Size = new System.Drawing.Size(333, 82);
            this.playerNamePanel.TabIndex = 8;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(2, 2);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(129, 30);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Animated = true;
            this.txtPlayerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.BorderRadius = 6;
            this.txtPlayerName.BorderThickness = 2;
            this.txtPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerName.DefaultText = "";
            this.txtPlayerName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtPlayerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.ForeColor = System.Drawing.Color.Black;
            this.txtPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.Location = new System.Drawing.Point(2, 38);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PlaceholderForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPlayerName.PlaceholderText = "Enter your name";
            this.txtPlayerName.SelectedText = "";
            this.txtPlayerName.Size = new System.Drawing.Size(329, 42);
            this.txtPlayerName.TabIndex = 5;
            // 
            // soundVolumePanel
            // 
            this.soundVolumePanel.Controls.Add(this.lblSoundVolume);
            this.soundVolumePanel.Controls.Add(this.volumeTrackBar);
            this.soundVolumePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundVolumePanel.Location = new System.Drawing.Point(500, 243);
            this.soundVolumePanel.Margin = new System.Windows.Forms.Padding(500, 20, 500, 20);
            this.soundVolumePanel.Name = "soundVolumePanel";
            this.soundVolumePanel.Padding = new System.Windows.Forms.Padding(2);
            this.soundVolumePanel.Size = new System.Drawing.Size(333, 65);
            this.soundVolumePanel.TabIndex = 7;
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblSoundVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoundVolume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundVolume.Location = new System.Drawing.Point(2, 2);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(145, 30);
            this.lblSoundVolume.TabIndex = 5;
            this.lblSoundVolume.Text = "Sound Volume:";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.volumeTrackBar.FillColor = System.Drawing.Color.LightGray;
            this.volumeTrackBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.volumeTrackBar.Location = new System.Drawing.Point(2, 40);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(329, 23);
            this.volumeTrackBar.TabIndex = 3;
            this.volumeTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // OptionsControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "OptionsControl";
            this.Size = new System.Drawing.Size(1533, 834);
            this.mainPanel.ResumeLayout(false);
            this.vStack.ResumeLayout(false);
            this.vStack.PerformLayout();
            this.playerNamePanel.ResumeLayout(false);
            this.playerNamePanel.PerformLayout();
            this.soundVolumePanel.ResumeLayout(false);
            this.soundVolumePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}