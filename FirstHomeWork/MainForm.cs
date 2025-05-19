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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            LoadControl(new MainMenuControl(this)); // Load main menu on startup
        }

        public void LoadControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            this.Controls.Clear(); // Remove existing content
            this.Controls.Add(control);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
