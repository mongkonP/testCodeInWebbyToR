using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0300__params
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Demonstrateparams.htm
    public partial  class frmDemonstrateparams:Form
    {
        public frmDemonstrateparams()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateparams
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateparams";
            this.Text = "frmDemonstrateparams";
            this.Load += new System.EventHandler(this.frmDemonstrateparams_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateparams_Load(object sender, EventArgs e)
        {

        }
    }
}
