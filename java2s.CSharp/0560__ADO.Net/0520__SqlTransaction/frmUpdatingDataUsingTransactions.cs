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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdatingDataUsingTransactions.htm
    public partial  class frmUpdatingDataUsingTransactions:Form
    {
        public frmUpdatingDataUsingTransactions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatingDataUsingTransactions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatingDataUsingTransactions";
            this.Text = "frmUpdatingDataUsingTransactions";
            this.Load += new System.EventHandler(this.frmUpdatingDataUsingTransactions_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatingDataUsingTransactions_Load(object sender, EventArgs e)
        {

        }
    }
}
