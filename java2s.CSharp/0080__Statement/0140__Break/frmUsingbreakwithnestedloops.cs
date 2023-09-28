using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0140__Break
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Usingbreakwithnestedloops.htm
    public partial  class frmUsingbreakwithnestedloops:Form
    {
        public frmUsingbreakwithnestedloops()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingbreakwithnestedloops
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingbreakwithnestedloops";
            this.Text = "frmUsingbreakwithnestedloops";
            this.Load += new System.EventHandler(this.frmUsingbreakwithnestedloops_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingbreakwithnestedloops_Load(object sender, EventArgs e)
        {

        }
    }
}
