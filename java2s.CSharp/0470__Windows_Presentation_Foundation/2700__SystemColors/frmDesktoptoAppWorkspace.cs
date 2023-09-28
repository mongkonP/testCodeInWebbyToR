using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2700__SystemColors
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DesktoptoAppWorkspace.htm
    public partial  class frmDesktoptoAppWorkspace:Form
    {
        public frmDesktoptoAppWorkspace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDesktoptoAppWorkspace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDesktoptoAppWorkspace";
            this.Text = "frmDesktoptoAppWorkspace";
            this.Load += new System.EventHandler(this.frmDesktoptoAppWorkspace_Load);
            this.ResumeLayout(false);

        }

        private void frmDesktoptoAppWorkspace_Load(object sender, EventArgs e)
        {

        }
    }
}
