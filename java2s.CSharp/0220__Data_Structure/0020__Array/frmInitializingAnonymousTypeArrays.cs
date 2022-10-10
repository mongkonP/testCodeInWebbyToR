using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0020__Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/InitializingAnonymousTypeArrays.htm
    public partial  class frmInitializingAnonymousTypeArrays:Form
    {
        public frmInitializingAnonymousTypeArrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInitializingAnonymousTypeArrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInitializingAnonymousTypeArrays";
            this.Text = "frmInitializingAnonymousTypeArrays";
            this.Load += new System.EventHandler(this.frmInitializingAnonymousTypeArrays_Load);
            this.ResumeLayout(false);

        }

        private void frmInitializingAnonymousTypeArrays_Load(object sender, EventArgs e)
        {

        }
    }
}
