using System.Drawing;
using System.Windows.Forms;

namespace FirstHomeWork
{
    partial class MainMenuControl
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.vStack = new System.Windows.Forms.TableLayoutPanel();
            this.optionsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanel.SuspendLayout();
            this.vStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.vStack);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(100);
            this.mainPanel.Size = new System.Drawing.Size(1533, 834);
            this.mainPanel.TabIndex = 0;
            // 
            // vStack
            // 
            this.vStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vStack.BackColor = System.Drawing.Color.White;
            this.vStack.ColumnCount = 1;
            this.vStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vStack.Controls.Add(this.optionsBtn, 0, 3);
            this.vStack.Controls.Add(this.logo, 0, 0);
            this.vStack.Controls.Add(this.startBtn, 0, 2);
            this.vStack.Controls.Add(this.title, 0, 1);
            this.vStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vStack.Location = new System.Drawing.Point(100, 100);
            this.vStack.Name = "vStack";
            this.vStack.RowCount = 4;
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.12459F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.46747F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70397F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70397F));
            this.vStack.Size = new System.Drawing.Size(1333, 634);
            this.vStack.TabIndex = 1;
            this.vStack.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
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
            this.optionsBtn.Location = new System.Drawing.Point(500, 536);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(500, 10, 500, 25);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.PressedDepth = 12;
            this.optionsBtn.ShadowDecoration.BorderRadius = 16;
            this.optionsBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.optionsBtn.ShadowDecoration.Depth = 60;
            this.optionsBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.optionsBtn.Size = new System.Drawing.Size(333, 73);
            this.optionsBtn.TabIndex = 5;
            this.optionsBtn.Text = "options";
            this.optionsBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.optionsBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.optionsBtn.UseTransparentBackground = true;
            this.optionsBtn.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::FirstHomeWork.Properties.Resources.logo_png;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1327, 292);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
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
            this.startBtn.Location = new System.Drawing.Point(500, 446);
            this.startBtn.Margin = new System.Windows.Forms.Padding(500, 25, 500, 10);
            this.startBtn.Name = "startBtn";
            this.startBtn.PressedDepth = 12;
            this.startBtn.ShadowDecoration.BorderRadius = 16;
            this.startBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startBtn.ShadowDecoration.Depth = 60;
            this.startBtn.ShadowDecoration.Enabled = true;
            this.startBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.startBtn.Size = new System.Drawing.Size(333, 70);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.startBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.startBtn.UseTransparentBackground = true;
            this.startBtn.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = false;
            this.title.AutoSizeHeightOnly = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.IsContextMenuEnabled = false;
            this.title.IsSelectionEnabled = false;
            this.title.Location = new System.Drawing.Point(10, 308);
            this.title.Margin = new System.Windows.Forms.Padding(10, 10, 10, 70);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1313, 74);
            this.title.TabIndex = 1;
            this.title.Text = "Spot The Difference";
            this.title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mainPanel);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(1533, 834);
            this.mainPanel.ResumeLayout(false);
            this.vStack.ResumeLayout(false);
            this.vStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel vStack;
        private Guna.UI2.WinForms.Guna2HtmlLabel title;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2Button optionsBtn;
    }
}