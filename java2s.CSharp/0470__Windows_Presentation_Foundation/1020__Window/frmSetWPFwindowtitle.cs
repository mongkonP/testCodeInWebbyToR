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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetWPFwindowtitle.htm
    public partial  class frmSetWPFwindowtitle:Form
    {
        public frmSetWPFwindowtitle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetWPFwindowtitle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetWPFwindowtitle";
            this.Text = "frmSetWPFwindowtitle";
            this.Load += new System.EventHandler(this.frmSetWPFwindowtitle_Load);
            this.ResumeLayout(false);

        }

        private void frmSetWPFwindowtitle_Load(object sender, EventArgs e)
        {

        }
    }
}
