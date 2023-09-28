using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0840__ODBC
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OdbcProvider.htm
    public partial  class frmOdbcProvider:Form
    {
        public frmOdbcProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOdbcProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOdbcProvider";
            this.Text = "frmOdbcProvider";
            this.Load += new System.EventHandler(this.frmOdbcProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmOdbcProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
