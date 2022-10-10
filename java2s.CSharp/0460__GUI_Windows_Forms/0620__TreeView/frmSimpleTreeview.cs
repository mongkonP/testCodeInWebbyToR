using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0620__TreeView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpleTreeview.htm
    public partial  class frmSimpleTreeview:Form
    {
        public frmSimpleTreeview()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleTreeview
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleTreeview";
            this.Text = "frmSimpleTreeview";
            this.Load += new System.EventHandler(this.frmSimpleTreeview_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleTreeview_Load(object sender, EventArgs e)
        {

        }
    }
}
