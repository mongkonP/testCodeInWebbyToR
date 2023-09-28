using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListQueryWithDelegatesCompact.htm
    public partial  class frmListQueryWithDelegatesCompact:Form
    {
        public frmListQueryWithDelegatesCompact()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListQueryWithDelegatesCompact
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListQueryWithDelegatesCompact";
            this.Text = "frmListQueryWithDelegatesCompact";
            this.Load += new System.EventHandler(this.frmListQueryWithDelegatesCompact_Load);
            this.ResumeLayout(false);

        }

        private void frmListQueryWithDelegatesCompact_Load(object sender, EventArgs e)
        {

        }
    }
}
