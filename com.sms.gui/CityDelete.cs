using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sms.handler;

namespace com.sms.gui
{
    public partial class CityDelete : Form
    {
        public CityDelete()
        {
            InitializeComponent();
        }

        private void CityDelete_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
