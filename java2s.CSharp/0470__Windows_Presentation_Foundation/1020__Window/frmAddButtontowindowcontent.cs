using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddButtontowindowcontent.htm
    public partial  class frmAddButtontowindowcontent:Form
    {
        public frmAddButtontowindowcontent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddButtontowindowcontent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddButtontowindowcontent";
            this.Text = "frmAddButtontowindowcontent";
            this.Load += new System.EventHandler(this.frmAddButtontowindowcontent_Load);
            this.ResumeLayout(false);

        }

        private void frmAddButtontowindowcontent_Load(object sender, EventArgs e)
        {

        }
    }
}
