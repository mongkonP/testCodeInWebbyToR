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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RetrievingDataUsingaSQLServerStoredProcedure.htm
    public partial  class frmRetrievingDataUsingaSQLServerStoredProcedure:Form
    {
        public frmRetrievingDataUsingaSQLServerStoredProcedure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingDataUsingaSQLServerStoredProcedure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingDataUsingaSQLServerStoredProcedure";
            this.Text = "frmRetrievingDataUsingaSQLServerStoredProcedure";
            this.Load += new System.EventHandler(this.frmRetrievingDataUsingaSQLServerStoredProcedure_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingDataUsingaSQLServerStoredProcedure_Load(object sender, EventArgs e)
        {

        }
    }
}
