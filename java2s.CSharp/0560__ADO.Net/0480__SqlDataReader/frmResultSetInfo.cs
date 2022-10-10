using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0480__SqlDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ResultSetInfo.htm
    public partial  class frmResultSetInfo:Form
    {
        public frmResultSetInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResultSetInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResultSetInfo";
            this.Text = "frmResultSetInfo";
            this.Load += new System.EventHandler(this.frmResultSetInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmResultSetInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
