using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1100__Cursor
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Setcursorarea.htm
    public partial  class frmSetcursorarea:Form
    {
        public frmSetcursorarea()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetcursorarea
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetcursorarea";
            this.Text = "frmSetcursorarea";
            this.Load += new System.EventHandler(this.frmSetcursorarea_Load);
            this.ResumeLayout(false);

        }

        private void frmSetcursorarea_Load(object sender, EventArgs e)
        {

        }
    }
}
