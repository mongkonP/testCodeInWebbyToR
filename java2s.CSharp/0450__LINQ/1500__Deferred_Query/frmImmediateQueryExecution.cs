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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ImmediateQueryExecution.htm
    public partial  class frmImmediateQueryExecution:Form
    {
        public frmImmediateQueryExecution()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImmediateQueryExecution
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImmediateQueryExecution";
            this.Text = "frmImmediateQueryExecution";
            this.Load += new System.EventHandler(this.frmImmediateQueryExecution_Load);
            this.ResumeLayout(false);

        }

        private void frmImmediateQueryExecution_Load(object sender, EventArgs e)
        {

        }
    }
}
