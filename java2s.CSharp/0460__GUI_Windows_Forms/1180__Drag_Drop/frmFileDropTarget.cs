using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1180__Drag_Drop
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FileDropTarget.htm
    public partial  class frmFileDropTarget:Form
    {
        public frmFileDropTarget()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileDropTarget
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileDropTarget";
            this.Text = "frmFileDropTarget";
            this.Load += new System.EventHandler(this.frmFileDropTarget_Load);
            this.ResumeLayout(false);

        }

        private void frmFileDropTarget_Load(object sender, EventArgs e)
        {

        }
    }
}
