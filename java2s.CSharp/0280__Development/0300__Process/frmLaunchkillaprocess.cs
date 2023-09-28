using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Launchkillaprocess.htm
    public partial  class frmLaunchkillaprocess:Form
    {
        public frmLaunchkillaprocess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLaunchkillaprocess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLaunchkillaprocess";
            this.Text = "frmLaunchkillaprocess";
            this.Load += new System.EventHandler(this.frmLaunchkillaprocess_Load);
            this.ResumeLayout(false);

        }

        private void frmLaunchkillaprocess_Load(object sender, EventArgs e)
        {

        }
    }
}
