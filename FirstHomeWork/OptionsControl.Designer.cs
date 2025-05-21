namespace FirstHomeWork
{
    partial class OptionsControl
    {
        private System.ComponentModel.IContainer components = null;

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
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlayerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.volumeTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.mainPanel.SuspendLayout();
            this.vStack.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.vStack.Controls.Add(this.startBtn, 0, 3);
            this.vStack.Controls.Add(this.title, 0, 0);
            this.vStack.Controls.Add(this.panel2, 0, 1);
            this.vStack.Controls.Add(this.panel1, 0, 2);
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
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Animated = true;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BorderColor = System.Drawing.Color.Transparent;
            this.startBtn.BorderRadius = 16;
            this.startBtn.BorderThickness = 5;
            this.startBtn.DefaultAutoSize = true;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(500, 338);
            this.startBtn.Margin = new System.Windows.Forms.Padding(500, 10, 500, 25);
            this.startBtn.Name = "startBtn";
            this.startBtn.PressedDepth = 12;
            this.startBtn.ShadowDecoration.BorderRadius = 16;
            this.startBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startBtn.ShadowDecoration.Depth = 60;
            this.startBtn.ShadowDecoration.Enabled = true;
            this.startBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.startBtn.Size = new System.Drawing.Size(333, 71);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Save";
            this.startBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.startBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.startBtn.UseTransparentBackground = true;
            this.startBtn.Click += new System.EventHandler(this.btnBack_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPlayerName);
            this.panel2.Controls.Add(this.txtPlayerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(500, 20, 500, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(333, 82);
            this.panel2.TabIndex = 8;
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
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.volumeTrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(500, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(500, 20, 500, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(333, 65);
            this.panel1.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(145, 30);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Sound Volume:";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel vStack;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel title;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlayerName;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TrackBar volumeTrackBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}