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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToolBarTray.htm
    public partial  class frmToolBarTray:Form
    {
        public frmToolBarTray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarTray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarTray";
            this.Text = "frmToolBarTray";
            this.Load += new System.EventHandler(this.frmToolBarTray_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarTray_Load(object sender, EventArgs e)
        {

        }
    }
}
