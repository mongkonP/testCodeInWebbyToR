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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usingthethreadpoolandnoarguments.htm
    public partial  class frmUsingthethreadpoolandnoarguments:Form
    {
        public frmUsingthethreadpoolandnoarguments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingthethreadpoolandnoarguments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingthethreadpoolandnoarguments";
            this.Text = "frmUsingthethreadpoolandnoarguments";
            this.Load += new System.EventHandler(this.frmUsingthethreadpoolandnoarguments_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingthethreadpoolandnoarguments_Load(object sender, EventArgs e)
        {

        }
    }
}
