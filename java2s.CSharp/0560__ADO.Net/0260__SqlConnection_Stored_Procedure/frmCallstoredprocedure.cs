using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0260__SqlConnection_Stored_Procedure
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Callstoredprocedure.htm
    public partial  class frmCallstoredprocedure:Form
    {
        public frmCallstoredprocedure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallstoredprocedure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallstoredprocedure";
            this.Text = "frmCallstoredprocedure";
            this.Load += new System.EventHandler(this.frmCallstoredprocedure_Load);
            this.ResumeLayout(false);

        }

        private void frmCallstoredprocedure_Load(object sender, EventArgs e)
        {

        }
    }
}
