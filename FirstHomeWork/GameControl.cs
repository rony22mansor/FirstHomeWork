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
    public partial class GameControl : UserControl
    {
        private MainForm parent;

        public GameControl(MainForm parentForm)
        {
            InitializeComponent();
            parent = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new MainMenuControl(parent));
        }
    }
}
