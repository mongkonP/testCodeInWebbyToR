using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0200__Background_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Movethreadtobackground.htm
    public partial  class frmMovethreadtobackground:Form
    {
        public frmMovethreadtobackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMovethreadtobackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMovethreadtobackground";
            this.Text = "frmMovethreadtobackground";
            this.Load += new System.EventHandler(this.frmMovethreadtobackground_Load);
            this.ResumeLayout(false);

        }

        private void frmMovethreadtobackground_Load(object sender, EventArgs e)
        {

        }
    }
}
