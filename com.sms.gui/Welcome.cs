using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.sms.gui
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            // radLiveTileElement1.Size = this.Size;
        }
        private enum TaskBarLocation { TOP, BOTTOM, LEFT, RIGHT }
        private void Welcome_Resize(object sender, EventArgs e)
        {
            radLiveTileElement1.Size =new Size( radPanorama1.Size.Width-10,radPanorama1.Size.Height-10);
        }
    }
}
