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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MenuItemswithCommands.htm
    public partial  class frmMenuItemswithCommands:Form
    {
        public frmMenuItemswithCommands()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMenuItemswithCommands
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMenuItemswithCommands";
            this.Text = "frmMenuItemswithCommands";
            this.Load += new System.EventHandler(this.frmMenuItemswithCommands_Load);
            this.ResumeLayout(false);

        }

        private void frmMenuItemswithCommands_Load(object sender, EventArgs e)
        {

        }
    }
}
