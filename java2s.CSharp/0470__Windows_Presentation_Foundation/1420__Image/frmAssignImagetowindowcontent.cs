using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AssignImagetowindowcontent.htm
    public partial  class frmAssignImagetowindowcontent:Form
    {
        public frmAssignImagetowindowcontent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssignImagetowindowcontent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssignImagetowindowcontent";
            this.Text = "frmAssignImagetowindowcontent";
            this.Load += new System.EventHandler(this.frmAssignImagetowindowcontent_Load);
            this.ResumeLayout(false);

        }

        private void frmAssignImagetowindowcontent_Load(object sender, EventArgs e)
        {

        }
    }
}
