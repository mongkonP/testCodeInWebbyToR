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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectionPoolingSample.htm
    public partial  class frmConnectionPoolingSample:Form
    {
        public frmConnectionPoolingSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectionPoolingSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectionPoolingSample";
            this.Text = "frmConnectionPoolingSample";
            this.Load += new System.EventHandler(this.frmConnectionPoolingSample_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectionPoolingSample_Load(object sender, EventArgs e)
        {

        }
    }
}
