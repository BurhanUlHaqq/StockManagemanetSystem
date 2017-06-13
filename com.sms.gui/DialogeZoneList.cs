using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.sms.config;
using com.sms.handler;

namespace com.sms.gui
{
    public partial class DialogeZoneList : Form
    {
        public DialogeZoneList()
        {
            InitializeComponent();
        }

        private void DialogeZoneList_Load(object sender, EventArgs e)
        {
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_ZONE);
        }
    }
}
