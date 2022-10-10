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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ImplicitTransaction.htm
    public partial  class frmImplicitTransaction:Form
    {
        public frmImplicitTransaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplicitTransaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplicitTransaction";
            this.Text = "frmImplicitTransaction";
            this.Load += new System.EventHandler(this.frmImplicitTransaction_Load);
            this.ResumeLayout(false);

        }

        private void frmImplicitTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
