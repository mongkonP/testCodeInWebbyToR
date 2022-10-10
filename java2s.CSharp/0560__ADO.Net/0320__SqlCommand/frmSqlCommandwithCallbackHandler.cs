using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0320__SqlCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SqlCommandwithCallbackHandler.htm
    public partial  class frmSqlCommandwithCallbackHandler:Form
    {
        public frmSqlCommandwithCallbackHandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSqlCommandwithCallbackHandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSqlCommandwithCallbackHandler";
            this.Text = "frmSqlCommandwithCallbackHandler";
            this.Load += new System.EventHandler(this.frmSqlCommandwithCallbackHandler_Load);
            this.ResumeLayout(false);

        }

        private void frmSqlCommandwithCallbackHandler_Load(object sender, EventArgs e)
        {

        }
    }
}
