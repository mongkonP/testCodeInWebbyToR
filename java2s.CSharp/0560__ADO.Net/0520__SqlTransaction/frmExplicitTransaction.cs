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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExplicitTransaction.htm
    public partial  class frmExplicitTransaction:Form
    {
        public frmExplicitTransaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExplicitTransaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExplicitTransaction";
            this.Text = "frmExplicitTransaction";
            this.Load += new System.EventHandler(this.frmExplicitTransaction_Load);
            this.ResumeLayout(false);

        }

        private void frmExplicitTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
