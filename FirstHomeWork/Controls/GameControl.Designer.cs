namespace FirstHomeWork
{
    partial class GameControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Button btnBack;

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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1425, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(3, 3);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(106, 56);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "01:00";
            this.lblTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTimer);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(1584, 600);
            this.Load += new System.EventHandler(this.GameControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}