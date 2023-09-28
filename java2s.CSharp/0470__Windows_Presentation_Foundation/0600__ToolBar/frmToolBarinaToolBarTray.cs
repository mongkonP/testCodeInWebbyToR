using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0600__ToolBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolBarinaToolBarTray.htm
    public partial  class frmToolBarinaToolBarTray:Form
    {
        public frmToolBarinaToolBarTray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarinaToolBarTray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarinaToolBarTray";
            this.Text = "frmToolBarinaToolBarTray";
            this.Load += new System.EventHandler(this.frmToolBarinaToolBarTray_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarinaToolBarTray_Load(object sender, EventArgs e)
        {

        }
    }
}
