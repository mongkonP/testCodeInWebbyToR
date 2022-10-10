using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderQueryResults.htm
    public partial  class frmOrderQueryResults:Form
    {
        public frmOrderQueryResults()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderQueryResults
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderQueryResults";
            this.Text = "frmOrderQueryResults";
            this.Load += new System.EventHandler(this.frmOrderQueryResults_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderQueryResults_Load(object sender, EventArgs e)
        {

        }
    }
}
