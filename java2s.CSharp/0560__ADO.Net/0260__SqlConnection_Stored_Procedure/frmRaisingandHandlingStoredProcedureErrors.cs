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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RaisingandHandlingStoredProcedureErrors.htm
    public partial  class frmRaisingandHandlingStoredProcedureErrors:Form
    {
        public frmRaisingandHandlingStoredProcedureErrors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRaisingandHandlingStoredProcedureErrors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRaisingandHandlingStoredProcedureErrors";
            this.Text = "frmRaisingandHandlingStoredProcedureErrors";
            this.Load += new System.EventHandler(this.frmRaisingandHandlingStoredProcedureErrors_Load);
            this.ResumeLayout(false);

        }

        private void frmRaisingandHandlingStoredProcedureErrors_Load(object sender, EventArgs e)
        {

        }
    }
}
