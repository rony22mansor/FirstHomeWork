using System;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class OptionsControl : UserControl
    {
        public int Volume => volumeTrackBar.Value;
        public string PlayerName => txtPlayerName.Text;

        private MainForm parent;

        public OptionsControl(MainForm parentForm)
        {
            InitializeComponent();
            volumeTrackBar.Value = SettingsManager.Volume;
            txtPlayerName.Text = SettingsManager.PlayerName;
            parent = parentForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsManager.PlayerName = this.PlayerName;
            SettingsManager.Volume = this.Volume;
            Console.WriteLine(SettingsManager.Volume);
            Console.WriteLine(SettingsManager.PlayerName);
            parent.LoadControl(new MainMenuControl(parent));
        }
    }
}