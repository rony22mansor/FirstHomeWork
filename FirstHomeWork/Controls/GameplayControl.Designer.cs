using System.Drawing;
using System.Windows.Forms;

namespace FirstHomeWork
{
    partial class GameplayControl
    {
        private System.Windows.Forms.Timer gameTimer;
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel gameInfoPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel vStack;
        private Guna.UI2.WinForms.Guna2Panel picturesSection;
        private System.Windows.Forms.TableLayoutPanel hStack;
        private Guna.UI2.WinForms.Guna2PictureBox pbOriginalImage;
        private System.Windows.Forms.SplitContainer topBar;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2PictureBox pbEditedImage;
        private Guna.UI2.WinForms.Guna2Panel divider;
        private Guna.UI2.WinForms.Guna2HtmlLabel differencesFoundLabel;

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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.vStack = new System.Windows.Forms.TableLayoutPanel();
            this.picturesSection = new Guna.UI2.WinForms.Guna2Panel();
            this.hStack = new System.Windows.Forms.TableLayoutPanel();
            this.pbEditedImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbOriginalImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.divider = new Guna.UI2.WinForms.Guna2Panel();
            this.topBar = new System.Windows.Forms.SplitContainer();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lblAttempts = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.differencesFoundLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbFeedbackIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mainPanel.SuspendLayout();
            this.vStack.SuspendLayout();
            this.picturesSection.SuspendLayout();
            this.hStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.topBar.Panel1.SuspendLayout();
            this.topBar.Panel2.SuspendLayout();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeedbackIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gameInfoPanel
            // 
            this.gameInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.gameInfoPanel.Name = "gameInfoPanel";
            this.gameInfoPanel.Size = new System.Drawing.Size(200, 100);
            this.gameInfoPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.vStack);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(20, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1493, 794);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // vStack
            // 
            this.vStack.ColumnCount = 1;
            this.vStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.vStack.Controls.Add(this.picturesSection, 0, 1);
            this.vStack.Controls.Add(this.topBar, 0, 0);
            this.vStack.Controls.Add(this.differencesFoundLabel, 0, 2);
            this.vStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vStack.Location = new System.Drawing.Point(0, 0);
            this.vStack.Name = "vStack";
            this.vStack.RowCount = 3;
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44541F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.55459F));
            this.vStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.vStack.Size = new System.Drawing.Size(1493, 794);
            this.vStack.TabIndex = 9;
            // 
            // picturesSection
            // 
            this.picturesSection.Controls.Add(this.hStack);
            this.picturesSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturesSection.Location = new System.Drawing.Point(3, 93);
            this.picturesSection.Name = "picturesSection";
            this.picturesSection.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.picturesSection.ShadowDecoration.BorderRadius = 12;
            this.picturesSection.ShadowDecoration.Depth = 120;
            this.picturesSection.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.picturesSection.Size = new System.Drawing.Size(1487, 628);
            this.picturesSection.TabIndex = 7;
            // 
            // hStack
            // 
            this.hStack.ColumnCount = 3;
            this.hStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.hStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.hStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.hStack.Controls.Add(this.pbEditedImage, 2, 0);
            this.hStack.Controls.Add(this.pbOriginalImage, 0, 0);
            this.hStack.Controls.Add(this.divider, 1, 0);
            this.hStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hStack.Location = new System.Drawing.Point(100, 0);
            this.hStack.Name = "hStack";
            this.hStack.RowCount = 1;
            this.hStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hStack.Size = new System.Drawing.Size(1287, 628);
            this.hStack.TabIndex = 5;
            // 
            // pbEditedImage
            // 
            this.pbEditedImage.BackColor = System.Drawing.Color.White;
            this.pbEditedImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbEditedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEditedImage.ImageRotate = 0F;
            this.pbEditedImage.Location = new System.Drawing.Point(658, 3);
            this.pbEditedImage.Name = "pbEditedImage";
            this.pbEditedImage.Size = new System.Drawing.Size(626, 622);
            this.pbEditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditedImage.TabIndex = 6;
            this.pbEditedImage.TabStop = false;
            this.pbEditedImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbEditedImage_MouseClick);
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.BackColor = System.Drawing.Color.White;
            this.pbOriginalImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbOriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginalImage.ImageRotate = 0F;
            this.pbOriginalImage.Location = new System.Drawing.Point(0, 0);
            this.pbOriginalImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(630, 628);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalImage.TabIndex = 4;
            this.pbOriginalImage.TabStop = false;
            this.pbOriginalImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbOriginalImage_MouseClick);
            // 
            // divider
            // 
            this.divider.AutoRoundedCorners = true;
            this.divider.BackColor = System.Drawing.Color.Transparent;
            this.divider.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.divider.BorderRadius = 3;
            this.divider.BorderThickness = 3;
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.divider.Location = new System.Drawing.Point(638, 20);
            this.divider.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(9, 588);
            this.divider.TabIndex = 7;
            this.divider.UseTransparentBackground = true;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBar.Location = new System.Drawing.Point(3, 3);
            this.topBar.Name = "topBar";
            // 
            // topBar.Panel1
            // 
            this.topBar.Panel1.Controls.Add(this.exitBtn);
            this.topBar.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 550, 20);
            // 
            // topBar.Panel2
            // 
            this.topBar.Panel2.Controls.Add(this.pbFeedbackIcon);
            this.topBar.Panel2.Controls.Add(this.lblAttempts);
            this.topBar.Panel2.Controls.Add(this.lblTimer);
            this.topBar.Panel2.Margin = new System.Windows.Forms.Padding(5);
            this.topBar.Panel2.Padding = new System.Windows.Forms.Padding(100, 0, 10, 10);
            this.topBar.Size = new System.Drawing.Size(1487, 84);
            this.topBar.SplitterDistance = 539;
            this.topBar.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Animated = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 16;
            this.exitBtn.BorderThickness = 5;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(119, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.exitBtn.PressedDepth = 12;
            this.exitBtn.ShadowDecoration.BorderRadius = 16;
            this.exitBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.exitBtn.ShadowDecoration.Depth = 60;
            this.exitBtn.ShadowDecoration.Enabled = true;
            this.exitBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.exitBtn.Size = new System.Drawing.Size(229, 64);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "X EXIT";
            this.exitBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.exitBtn.UseTransparentBackground = true;
            this.exitBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempts.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblAttempts.ForeColor = System.Drawing.Color.Black;
            this.lblAttempts.Location = new System.Drawing.Point(592, 5);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(249, 56);
            this.lblAttempts.TabIndex = 13;
            this.lblAttempts.Text = "Attempts: 10";
            this.lblAttempts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAttempts.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.IsContextMenuEnabled = false;
            this.lblTimer.IsSelectionEnabled = false;
            this.lblTimer.Location = new System.Drawing.Point(677, 5);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(106, 56);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "01:00";
            this.lblTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // differencesFoundLabel
            // 
            this.differencesFoundLabel.AutoSize = false;
            this.differencesFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.differencesFoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.differencesFoundLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.differencesFoundLabel.Location = new System.Drawing.Point(3, 727);
            this.differencesFoundLabel.Name = "differencesFoundLabel";
            this.differencesFoundLabel.Size = new System.Drawing.Size(1487, 64);
            this.differencesFoundLabel.TabIndex = 8;
            this.differencesFoundLabel.Text = null;
            this.differencesFoundLabel.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbFeedbackIcon
            // 
            this.pbFeedbackIcon.ImageRotate = 0F;
            this.pbFeedbackIcon.Location = new System.Drawing.Point(157, 0);
            this.pbFeedbackIcon.Name = "pbFeedbackIcon";
            this.pbFeedbackIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFeedbackIcon.Size = new System.Drawing.Size(89, 84);
            this.pbFeedbackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFeedbackIcon.TabIndex = 14;
            this.pbFeedbackIcon.TabStop = false;
            // 
            // GameplayControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "GameplayControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1533, 834);
            this.mainPanel.ResumeLayout(false);
            this.vStack.ResumeLayout(false);
            this.picturesSection.ResumeLayout(false);
            this.hStack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.topBar.Panel1.ResumeLayout(false);
            this.topBar.Panel2.ResumeLayout(false);
            this.topBar.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFeedbackIcon)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblAttempts;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFeedbackIcon;
    }
}