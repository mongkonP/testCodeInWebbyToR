using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1660__Clipboard
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ClipboardViewer.htm
    public partial  class frmClipboardViewer:Form
    {
        public frmClipboardViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClipboardViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClipboardViewer";
            this.Text = "frmClipboardViewer";
            this.Load += new System.EventHandler(this.frmClipboardViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmClipboardViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
