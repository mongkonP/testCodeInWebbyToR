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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpleClipboard.htm
    public partial  class frmSimpleClipboard:Form
    {
        public frmSimpleClipboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleClipboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleClipboard";
            this.Text = "frmSimpleClipboard";
            this.Load += new System.EventHandler(this.frmSimpleClipboard_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleClipboard_Load(object sender, EventArgs e)
        {

        }
    }
}
