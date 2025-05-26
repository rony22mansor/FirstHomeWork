using System.Windows.Forms;

namespace FirstHomeWork.Forms
{
    partial class LoseDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureCelebration;
        private Label labelCongrats;
        private Button buttonOkay;
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
            this.pictureCelebration = new System.Windows.Forms.PictureBox();
            this.labelCongrats = new System.Windows.Forms.Label();
            this.buttonOkay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCelebration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCelebration
            // 
            this.pictureCelebration.Location = new System.Drawing.Point(20, 20);
            this.pictureCelebration.Name = "pictureCelebration";
            this.pictureCelebration.Padding = new System.Windows.Forms.Padding(50);
            this.pictureCelebration.Size = new System.Drawing.Size(260, 150);
            this.pictureCelebration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCelebration.TabIndex = 0;
            this.pictureCelebration.TabStop = false;
            // 
            // labelCongrats
            // 
            this.labelCongrats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCongrats.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCongrats.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCongrats.Location = new System.Drawing.Point(20, 173);
            this.labelCongrats.Name = "labelCongrats";
            this.labelCongrats.Size = new System.Drawing.Size(260, 62);
            this.labelCongrats.TabIndex = 1;
            this.labelCongrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOkay
            // 
            this.buttonOkay.BackColor = System.Drawing.Color.IndianRed;
            this.buttonOkay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOkay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonOkay.ForeColor = System.Drawing.Color.White;
            this.buttonOkay.Location = new System.Drawing.Point(20, 235);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(260, 35);
            this.buttonOkay.TabIndex = 2;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = false;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // LoseDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 290);
            this.Controls.Add(this.pictureCelebration);
            this.Controls.Add(this.labelCongrats);
            this.Controls.Add(this.buttonOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoseDialog";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WinDialogForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCelebration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}