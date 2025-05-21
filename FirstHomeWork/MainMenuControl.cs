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

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
