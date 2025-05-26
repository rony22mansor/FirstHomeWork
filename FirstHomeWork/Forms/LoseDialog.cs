using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomeWork.Forms
{
    public partial class LoseDialog : Form
    {
        public LoseDialog()
        {
            InitializeComponent();
            pictureCelebration.Image = Image.FromFile(@"Resources\Graphics\lose.png");
            labelCongrats.Text = $"Sorry {SettingsManager.PlayerName}! You lose.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void WinDialogForm_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 6;
            Color borderColor = Color.IndianRed;

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            }
        }


        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
