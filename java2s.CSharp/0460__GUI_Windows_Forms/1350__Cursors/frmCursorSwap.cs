using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1350__Cursors
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CursorSwap.htm
    public partial  class frmCursorSwap:Form
    {
        public frmCursorSwap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCursorSwap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCursorSwap";
            this.Text = "frmCursorSwap";
            this.Load += new System.EventHandler(this.frmCursorSwap_Load);
            this.ResumeLayout(false);

        }

        private void frmCursorSwap_Load(object sender, EventArgs e)
        {

        }
    }
}
