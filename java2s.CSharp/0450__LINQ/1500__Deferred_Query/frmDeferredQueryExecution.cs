using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1500__Deferred_Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DeferredQueryExecution.htm
    public partial  class frmDeferredQueryExecution:Form
    {
        public frmDeferredQueryExecution()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeferredQueryExecution
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeferredQueryExecution";
            this.Text = "frmDeferredQueryExecution";
            this.Load += new System.EventHandler(this.frmDeferredQueryExecution_Load);
            this.ResumeLayout(false);

        }

        private void frmDeferredQueryExecution_Load(object sender, EventArgs e)
        {

        }
    }
}
