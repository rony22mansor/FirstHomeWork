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
    public partial class DebugingForm : Form
    {

        public DebugingForm(Bitmap diff, Bitmap gray)
        {
            InitializeComponent();
            this.pictureBox1.Image = diff;
            this.pictureBox2.Image = gray;
        }




    }
}
