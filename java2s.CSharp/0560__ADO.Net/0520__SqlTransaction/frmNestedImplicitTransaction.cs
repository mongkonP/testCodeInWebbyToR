using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0520__SqlTransaction
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/NestedImplicitTransaction.htm
    public partial  class frmNestedImplicitTransaction:Form
    {
        public frmNestedImplicitTransaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedImplicitTransaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedImplicitTransaction";
            this.Text = "frmNestedImplicitTransaction";
            this.Load += new System.EventHandler(this.frmNestedImplicitTransaction_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedImplicitTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
