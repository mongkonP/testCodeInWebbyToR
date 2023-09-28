using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0540__Data_Provider
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreateDatabaseconnectionfromDbProviderFactory.htm
    public partial  class frmCreateDatabaseconnectionfromDbProviderFactory:Form
    {
        public frmCreateDatabaseconnectionfromDbProviderFactory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateDatabaseconnectionfromDbProviderFactory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateDatabaseconnectionfromDbProviderFactory";
            this.Text = "frmCreateDatabaseconnectionfromDbProviderFactory";
            this.Load += new System.EventHandler(this.frmCreateDatabaseconnectionfromDbProviderFactory_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateDatabaseconnectionfromDbProviderFactory_Load(object sender, EventArgs e)
        {

        }
    }
}
