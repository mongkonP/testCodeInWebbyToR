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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CallStoredProcedurewithinputandoutputparameters.htm
    public partial  class frmCallStoredProcedurewithinputandoutputparameters:Form
    {
        public frmCallStoredProcedurewithinputandoutputparameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallStoredProcedurewithinputandoutputparameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallStoredProcedurewithinputandoutputparameters";
            this.Text = "frmCallStoredProcedurewithinputandoutputparameters";
            this.Load += new System.EventHandler(this.frmCallStoredProcedurewithinputandoutputparameters_Load);
            this.ResumeLayout(false);

        }

        private void frmCallStoredProcedurewithinputandoutputparameters_Load(object sender, EventArgs e)
        {

        }
    }
}
