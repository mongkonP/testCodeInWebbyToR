using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0860__OdbcConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UseODBCDataProvider.htm
    public partial  class frmUseODBCDataProvider:Form
    {
        public frmUseODBCDataProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseODBCDataProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseODBCDataProvider";
            this.Text = "frmUseODBCDataProvider";
            this.Load += new System.EventHandler(this.frmUseODBCDataProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmUseODBCDataProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
