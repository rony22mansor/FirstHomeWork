using System;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Store the settings globally
            SettingsManager.PlayerName = this.PlayerName;
            SettingsManager.Volume = this.Volume;
            Console.WriteLine(SettingsManager.Volume);
            Console.WriteLine(SettingsManager.PlayerName);
            parent.LoadControl(new MainMenuControl(parent));
        }
    }
}