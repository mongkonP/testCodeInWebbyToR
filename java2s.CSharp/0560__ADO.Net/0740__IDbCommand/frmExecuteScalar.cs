using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0740__IDbCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExecuteScalar.htm
    public partial  class frmExecuteScalar:Form
    {
        public frmExecuteScalar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecuteScalar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecuteScalar";
            this.Text = "frmExecuteScalar";
            this.Load += new System.EventHandler(this.frmExecuteScalar_Load);
            this.ResumeLayout(false);

        }

        private void frmExecuteScalar_Load(object sender, EventArgs e)
        {

        }
    }
}
