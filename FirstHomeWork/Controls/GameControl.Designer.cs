using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FirstHomeWork
{
    partial class GameControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;



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
            this.optionsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLevels = new System.Windows.Forms.Panel();
            this.levels = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutDropdowns = new System.Windows.Forms.FlowLayoutPanel();
            this.gameOptions = new System.Windows.Forms.TableLayoutPanel();
            this.gameMode = new System.Windows.Forms.Panel();
            this.gameModeDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gameModeTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.difficulty = new System.Windows.Forms.Panel();
            this.difficultyDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.difficultyTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanel.SuspendLayout();
            this.vStack.SuspendLayout();
            this.panelLevels.SuspendLayout();
            this.levels.SuspendLayout();
            this.gameOptions.SuspendLayout();
            this.gameMode.SuspendLayout();
            this.difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.vStack);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(133, 25, 133, 25);
            this.mainPanel.Size = new System.Drawing.Size(2044, 1026);
            this.mainPanel.TabIndex = 6;
            // 
            // vStack
            // 
            this.vStack.ColumnCount = 1;
            this.vStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vStack.Controls.Add(this.optionsBtn, 0, 4);
            this.vStack.Controls.Add(this.startBtn, 0, 3);
            this.vStack.Controls.Add(this.title, 0, 0);
            this.vStack.Controls.Add(this.panelLevels, 0, 1);
            this.vStack.Controls.Add(this.gameOptions, 0, 1);
            this.vStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vStack.Location = new System.Drawing.Point(133, 25);
            this.vStack.Margin = new System.Windows.Forms.Padding(0);
            this.vStack.Name = "vStack";
            this.vStack.RowCount = 5;
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.54767F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.41287F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.10992F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.vStack.Size = new System.Drawing.Size(1778, 976);
            this.vStack.TabIndex = 1;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsBtn.Animated = true;
            this.optionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.optionsBtn.BorderRadius = 16;
            this.optionsBtn.BorderThickness = 5;
            this.optionsBtn.DefaultAutoSize = true;
            this.optionsBtn.FillColor = System.Drawing.Color.Transparent;
            this.optionsBtn.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.optionsBtn.ForeColor = System.Drawing.Color.Black;
            this.optionsBtn.Location = new System.Drawing.Point(667, 872);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(667, 12, 667, 31);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.PressedDepth = 12;
            this.optionsBtn.ShadowDecoration.BorderRadius = 16;
            this.optionsBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.optionsBtn.ShadowDecoration.Depth = 60;
            this.optionsBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.optionsBtn.Size = new System.Drawing.Size(444, 73);
            this.optionsBtn.TabIndex = 14;
            this.optionsBtn.Text = "Back";
            this.optionsBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.optionsBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.optionsBtn.UseTransparentBackground = true;
            this.optionsBtn.Click += new System.EventHandler(this.btnBack_Click);
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
            this.startBtn.Location = new System.Drawing.Point(667, 777);
            this.startBtn.Margin = new System.Windows.Forms.Padding(667, 31, 667, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.PressedDepth = 12;
            this.startBtn.ShadowDecoration.BorderRadius = 16;
            this.startBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startBtn.ShadowDecoration.Depth = 60;
            this.startBtn.ShadowDecoration.Enabled = true;
            this.startBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.startBtn.Size = new System.Drawing.Size(444, 71);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.startBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.startBtn.UseTransparentBackground = true;
            this.startBtn.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // title
            // 
            this.title.AutoSize = false;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.IsContextMenuEnabled = false;
            this.title.IsSelectionEnabled = false;
            this.title.Location = new System.Drawing.Point(13, 12);
            this.title.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1752, 84);
            this.title.TabIndex = 10;
            this.title.Text = "Select The Level";
            this.title.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLevels
            // 
            this.panelLevels.AutoScroll = true;
            this.panelLevels.Controls.Add(this.levels);
            this.panelLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLevels.Location = new System.Drawing.Point(4, 112);
            this.panelLevels.Margin = new System.Windows.Forms.Padding(4);
            this.panelLevels.Name = "panelLevels";
            this.panelLevels.Padding = new System.Windows.Forms.Padding(220, 0, 220, 0);
            this.panelLevels.Size = new System.Drawing.Size(1770, 383);
            this.panelLevels.TabIndex = 12;
            // 
            // levels
            // 
            this.levels.AutoScroll = true;
            this.levels.Controls.Add(this.flowLayoutDropdowns);
            this.levels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levels.Location = new System.Drawing.Point(220, 0);
            this.levels.Margin = new System.Windows.Forms.Padding(4);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(1330, 383);
            this.levels.TabIndex = 0;
            this.levels.WrapContents = false;
            // 
            // flowLayoutDropdowns
            // 
            this.flowLayoutDropdowns.AutoSize = true;
            this.flowLayoutDropdowns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutDropdowns.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutDropdowns.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutDropdowns.Name = "flowLayoutDropdowns";
            this.flowLayoutDropdowns.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flowLayoutDropdowns.Size = new System.Drawing.Size(0, 25);
            this.flowLayoutDropdowns.TabIndex = 14;
            this.flowLayoutDropdowns.WrapContents = false;
            // 
            // gameOptions
            // 
            this.gameOptions.ColumnCount = 2;
            this.gameOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOptions.Controls.Add(this.gameMode, 0, 0);
            this.gameOptions.Controls.Add(this.difficulty, 1, 0);
            this.gameOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOptions.Location = new System.Drawing.Point(350, 509);
            this.gameOptions.Margin = new System.Windows.Forms.Padding(350, 10, 350, 30);
            this.gameOptions.Name = "gameOptions";
            this.gameOptions.Padding = new System.Windows.Forms.Padding(20);
            this.gameOptions.RowCount = 1;
            this.gameOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.gameOptions.Size = new System.Drawing.Size(1078, 207);
            this.gameOptions.TabIndex = 13;
            // 
            // gameMode
            // 
            this.gameMode.Controls.Add(this.gameModeDropDown);
            this.gameMode.Controls.Add(this.gameModeTitle);
            this.gameMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameMode.Location = new System.Drawing.Point(40, 20);
            this.gameMode.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.gameMode.Name = "gameMode";
            this.gameMode.Padding = new System.Windows.Forms.Padding(2);
            this.gameMode.Size = new System.Drawing.Size(479, 93);
            this.gameMode.TabIndex = 20;
            // 
            // gameModeDropDown
            // 
            this.gameModeDropDown.BackColor = System.Drawing.Color.Transparent;
            this.gameModeDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameModeDropDown.BorderRadius = 6;
            this.gameModeDropDown.BorderThickness = 2;
            this.gameModeDropDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameModeDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gameModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameModeDropDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameModeDropDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gameModeDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameModeDropDown.ItemHeight = 42;
            this.gameModeDropDown.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gameModeDropDown.Location = new System.Drawing.Point(2, 43);
            this.gameModeDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.gameModeDropDown.Name = "gameModeDropDown";
            this.gameModeDropDown.ShadowDecoration.BorderRadius = 16;
            this.gameModeDropDown.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameModeDropDown.ShadowDecoration.Depth = 60;
            this.gameModeDropDown.ShadowDecoration.Enabled = true;
            this.gameModeDropDown.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.gameModeDropDown.Size = new System.Drawing.Size(475, 48);
            this.gameModeDropDown.TabIndex = 16;
            this.gameModeDropDown.SelectedIndexChanged += new System.EventHandler(this.gameMode_SelectedIndexChanged);
            // 
            // gameModeTitle
            // 
            this.gameModeTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameModeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameModeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeTitle.Location = new System.Drawing.Point(2, 2);
            this.gameModeTitle.Name = "gameModeTitle";
            this.gameModeTitle.Size = new System.Drawing.Size(475, 89);
            this.gameModeTitle.TabIndex = 4;
            this.gameModeTitle.Text = "Game Mode:";
            // 
            // difficulty
            // 
            this.difficulty.Controls.Add(this.difficultyDropDown);
            this.difficulty.Controls.Add(this.difficultyTitle);
            this.difficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty.Location = new System.Drawing.Point(559, 20);
            this.difficulty.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.difficulty.Name = "difficulty";
            this.difficulty.Padding = new System.Windows.Forms.Padding(2);
            this.difficulty.Size = new System.Drawing.Size(479, 93);
            this.difficulty.TabIndex = 19;
            // 
            // difficultyDropDown
            // 
            this.difficultyDropDown.BackColor = System.Drawing.Color.Transparent;
            this.difficultyDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.difficultyDropDown.BorderRadius = 6;
            this.difficultyDropDown.BorderThickness = 2;
            this.difficultyDropDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.difficultyDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.difficultyDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.difficultyDropDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.difficultyDropDown.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.difficultyDropDown.ItemHeight = 42;
            this.difficultyDropDown.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.difficultyDropDown.Location = new System.Drawing.Point(2, 43);
            this.difficultyDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.difficultyDropDown.Name = "difficultyDropDown";
            this.difficultyDropDown.ShadowDecoration.BorderRadius = 16;
            this.difficultyDropDown.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.difficultyDropDown.ShadowDecoration.Depth = 60;
            this.difficultyDropDown.ShadowDecoration.Enabled = true;
            this.difficultyDropDown.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.difficultyDropDown.Size = new System.Drawing.Size(475, 48);
            this.difficultyDropDown.TabIndex = 16;
            this.difficultyDropDown.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // difficultyTitle
            // 
            this.difficultyTitle.BackColor = System.Drawing.Color.Transparent;
            this.difficultyTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyTitle.Location = new System.Drawing.Point(2, 2);
            this.difficultyTitle.Name = "difficultyTitle";
            this.difficultyTitle.Size = new System.Drawing.Size(475, 89);
            this.difficultyTitle.TabIndex = 4;
            this.difficultyTitle.Text = "Difficulty:";
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(2044, 1026);
            this.mainPanel.ResumeLayout(false);
            this.vStack.ResumeLayout(false);
            this.vStack.PerformLayout();
            this.panelLevels.ResumeLayout(false);
            this.levels.ResumeLayout(false);
            this.levels.PerformLayout();
            this.gameOptions.ResumeLayout(false);
            this.gameMode.ResumeLayout(false);
            this.gameMode.PerformLayout();
            this.difficulty.ResumeLayout(false);
            this.difficulty.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private TableLayoutPanel vStack;
        private Guna.UI2.WinForms.Guna2Button optionsBtn;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel title;
        private Panel panelLevels;
        private FlowLayoutPanel levels;
        private FlowLayoutPanel flowLayoutDropdowns;
        private TableLayoutPanel gameOptions;
        private Panel gameMode;
        private Guna.UI2.WinForms.Guna2ComboBox gameModeDropDown;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameModeTitle;
        private Panel difficulty;
        private Guna.UI2.WinForms.Guna2ComboBox difficultyDropDown;
        private Guna.UI2.WinForms.Guna2HtmlLabel difficultyTitle;
    }
}