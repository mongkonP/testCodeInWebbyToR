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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateCanvasascontentofwindow.htm
    public partial  class frmCreateCanvasascontentofwindow:Form
    {
        public frmCreateCanvasascontentofwindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateCanvasascontentofwindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateCanvasascontentofwindow";
            this.Text = "frmCreateCanvasascontentofwindow";
            this.Load += new System.EventHandler(this.frmCreateCanvasascontentofwindow_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateCanvasascontentofwindow_Load(object sender, EventArgs e)
        {

        }
    }
}
