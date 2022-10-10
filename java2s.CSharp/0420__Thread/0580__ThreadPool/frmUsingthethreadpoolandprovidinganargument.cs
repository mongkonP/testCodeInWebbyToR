using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usingthethreadpoolandprovidinganargument.htm
    public partial  class frmUsingthethreadpoolandprovidinganargument:Form
    {
        public frmUsingthethreadpoolandprovidinganargument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingthethreadpoolandprovidinganargument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingthethreadpoolandprovidinganargument";
            this.Text = "frmUsingthethreadpoolandprovidinganargument";
            this.Load += new System.EventHandler(this.frmUsingthethreadpoolandprovidinganargument_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingthethreadpoolandprovidinganargument_Load(object sender, EventArgs e)
        {

        }
    }
}
