using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0040__Generic_List
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Useforeachlooptodisplaythegenericlist.htm
    public partial  class frmUseforeachlooptodisplaythegenericlist:Form
    {
        public frmUseforeachlooptodisplaythegenericlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseforeachlooptodisplaythegenericlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseforeachlooptodisplaythegenericlist";
            this.Text = "frmUseforeachlooptodisplaythegenericlist";
            this.Load += new System.EventHandler(this.frmUseforeachlooptodisplaythegenericlist_Load);
            this.ResumeLayout(false);

        }

        private void frmUseforeachlooptodisplaythegenericlist_Load(object sender, EventArgs e)
        {

        }
    }
}
