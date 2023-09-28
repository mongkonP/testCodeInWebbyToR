using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1480__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RepaintcontrolinTimerevent.htm
    public partial  class frmRepaintcontrolinTimerevent:Form
    {
        public frmRepaintcontrolinTimerevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRepaintcontrolinTimerevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRepaintcontrolinTimerevent";
            this.Text = "frmRepaintcontrolinTimerevent";
            this.Load += new System.EventHandler(this.frmRepaintcontrolinTimerevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRepaintcontrolinTimerevent_Load(object sender, EventArgs e)
        {

        }
    }
}
