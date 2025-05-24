namespace FirstHomeWork
{
    partial class GameplayControl
    {
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picturesSection = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbEditedImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbOriginalImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.divider = new Guna.UI2.WinForms.Guna2Panel();
            this.topBar = new System.Windows.Forms.SplitContainer();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.differencesFoundLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.picturesSection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.topBar.Panel1.SuspendLayout();
            this.topBar.Panel2.SuspendLayout();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2004, 986);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.picturesSection, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.topBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.differencesFoundLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44541F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.55459F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2004, 986);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // picturesSection
            // 
            this.picturesSection.Controls.Add(this.tableLayoutPanel1);
            this.picturesSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturesSection.Location = new System.Drawing.Point(3, 117);
            this.picturesSection.Name = "picturesSection";
            this.picturesSection.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.picturesSection.ShadowDecoration.BorderRadius = 12;
            this.picturesSection.ShadowDecoration.Depth = 120;
            this.picturesSection.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.picturesSection.Size = new System.Drawing.Size(1998, 796);
            this.picturesSection.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Controls.Add(this.pbEditedImage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbOriginalImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.divider, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1798, 796);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pbEditedImage
            // 
            this.pbEditedImage.BackColor = System.Drawing.Color.White;
            this.pbEditedImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbEditedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEditedImage.ImageRotate = 0F;
            this.pbEditedImage.Location = new System.Drawing.Point(919, 3);
            this.pbEditedImage.Name = "pbEditedImage";
            this.pbEditedImage.Size = new System.Drawing.Size(876, 790);
            this.pbEditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditedImage.TabIndex = 6;
            this.pbEditedImage.TabStop = false;
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
            this.pbOriginalImage.Size = new System.Drawing.Size(881, 796);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalImage.TabIndex = 4;
            this.pbOriginalImage.TabStop = false;
            // 
            // divider
            // 
            this.divider.AutoRoundedCorners = true;
            this.divider.BackColor = System.Drawing.Color.Transparent;
            this.divider.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.divider.BorderRadius = 8;
            this.divider.BorderThickness = 3;
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.divider.Location = new System.Drawing.Point(889, 20);
            this.divider.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(19, 756);
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
            this.topBar.Panel2.Controls.Add(this.lblTimer);
            this.topBar.Panel2.Margin = new System.Windows.Forms.Padding(5);
            this.topBar.Panel2.Padding = new System.Windows.Forms.Padding(100, 0, 10, 10);
            this.topBar.Size = new System.Drawing.Size(1998, 108);
            this.topBar.SplitterDistance = 999;
            this.topBar.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Animated = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 16;
            this.exitBtn.BorderThickness = 5;
            this.exitBtn.DefaultAutoSize = true;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(10, 24);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.exitBtn.PressedDepth = 12;
            this.exitBtn.ShadowDecoration.BorderRadius = 16;
            this.exitBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.exitBtn.ShadowDecoration.Depth = 60;
            this.exitBtn.ShadowDecoration.Enabled = true;
            this.exitBtn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.exitBtn.Size = new System.Drawing.Size(439, 64);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "X EXIT";
            this.exitBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.exitBtn.UseTransparentBackground = true;
            this.exitBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = false;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.IsContextMenuEnabled = false;
            this.lblTimer.IsSelectionEnabled = false;
            this.lblTimer.Location = new System.Drawing.Point(100, 42);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(885, 56);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "01:00";
            this.lblTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // differencesFoundLabel
            // 
            this.differencesFoundLabel.AutoSize = false;
            this.differencesFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.differencesFoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.differencesFoundLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.differencesFoundLabel.Location = new System.Drawing.Point(3, 919);
            this.differencesFoundLabel.Name = "differencesFoundLabel";
            this.differencesFoundLabel.Size = new System.Drawing.Size(1998, 64);
            this.differencesFoundLabel.TabIndex = 8;
            this.differencesFoundLabel.Text = null;
            this.differencesFoundLabel.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GameplayControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "GameplayControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(2044, 1026);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.picturesSection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.topBar.Panel1.ResumeLayout(false);
            this.topBar.Panel1.PerformLayout();
            this.topBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel picturesSection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbOriginalImage;
        private System.Windows.Forms.SplitContainer topBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2PictureBox pbEditedImage;
        private Guna.UI2.WinForms.Guna2Panel divider;
        private Guna.UI2.WinForms.Guna2HtmlLabel differencesFoundLabel;
    }
}