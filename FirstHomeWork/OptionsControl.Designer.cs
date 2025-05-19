namespace FirstHomeWork
{
    partial class OptionsControl
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
        private Guna.UI2.WinForms.Guna2Button btnBack;

        private void InitializeComponent()
        {
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();

            // btnBack
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // OptionsControl
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Size = new System.Drawing.Size(800, 600);
        }

        #endregion
    }
}