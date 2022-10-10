using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0380__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MenuItemCommandsAndEvents.htm
    public partial  class frmMenuItemCommandsAndEvents:Form
    {
        public frmMenuItemCommandsAndEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMenuItemCommandsAndEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMenuItemCommandsAndEvents";
            this.Text = "frmMenuItemCommandsAndEvents";
            this.Load += new System.EventHandler(this.frmMenuItemCommandsAndEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmMenuItemCommandsAndEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
