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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OdbcConnectionforAccessmdbfile.htm
    public partial  class frmOdbcConnectionforAccessmdbfile:Form
    {
        public frmOdbcConnectionforAccessmdbfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOdbcConnectionforAccessmdbfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOdbcConnectionforAccessmdbfile";
            this.Text = "frmOdbcConnectionforAccessmdbfile";
            this.Load += new System.EventHandler(this.frmOdbcConnectionforAccessmdbfile_Load);
            this.ResumeLayout(false);

        }

        private void frmOdbcConnectionforAccessmdbfile_Load(object sender, EventArgs e)
        {

        }
    }
}
