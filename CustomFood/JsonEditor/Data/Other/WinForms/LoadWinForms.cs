// THIS FILE IS EXCLUDED FROM THE PROJECT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonEditor
{
    public partial class CustomFoodJsonEditor
    {
        public partial class Load
        {
            public static void WinForms(bool bl = false)
            {
                if (bl == false) return;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
