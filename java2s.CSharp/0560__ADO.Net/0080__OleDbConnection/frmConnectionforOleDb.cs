using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0080__OleDbConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectionforOleDb.htm
    public partial  class frmConnectionforOleDb:Form
    {
        public frmConnectionforOleDb()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectionforOleDb
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectionforOleDb";
            this.Text = "frmConnectionforOleDb";
            this.Load += new System.EventHandler(this.frmConnectionforOleDb_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectionforOleDb_Load(object sender, EventArgs e)
        {

        }
    }
}
