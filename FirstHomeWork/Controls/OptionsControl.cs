using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class OptionsControl : UserControl
    {
        public float Volume => volumeTrackBar.Value / 100f;
        public string PlayerName => txtPlayerName.Text;

        private MainForm parent;

        public OptionsControl(MainForm parentForm)
        {
            InitializeComponent();
            parent = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Store the settings globally
            SettingsManager.PlayerName = this.PlayerName;
            SettingsManager.Volume = this.Volume;
            Console.WriteLine(SettingsManager.Volume);
            Console.WriteLine(SettingsManager.PlayerName);
            parent.LoadControl(new MainMenuControl(parent));
        }

        private void vStack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }
    }
}
