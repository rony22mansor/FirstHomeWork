using System;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class MainMenuControl : UserControl
    {
        private MainForm parent;

        public MainMenuControl(MainForm parentForm)
        {
            InitializeComponent();
            parent = parentForm;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new GameControl(parent));
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new OptionsControl(parent));
        }
    }
}