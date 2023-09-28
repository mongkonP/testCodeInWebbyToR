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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Changewindowresizemode.htm
    public partial  class frmChangewindowresizemode:Form
    {
        public frmChangewindowresizemode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangewindowresizemode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangewindowresizemode";
            this.Text = "frmChangewindowresizemode";
            this.Load += new System.EventHandler(this.frmChangewindowresizemode_Load);
            this.ResumeLayout(false);

        }

        private void frmChangewindowresizemode_Load(object sender, EventArgs e)
        {

        }
    }
}
