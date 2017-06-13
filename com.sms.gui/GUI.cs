using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.sms.gui
{
    public class GUI
    {
        public static void loadFormInPanel(Panel panel, String FormName)
        {
            LoadGUI.LoadForm(panel,FormName);            
        }

        internal static void loadFormInDialoge(string ZONE_DIALOGE)
        {
            LoadGUI.LoadDialoge(ZONE_DIALOGE);
        }
    }
}
