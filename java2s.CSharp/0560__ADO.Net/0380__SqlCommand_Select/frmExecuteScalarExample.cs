using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0380__SqlCommand_Select
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExecuteScalarExample.htm
    public partial  class frmExecuteScalarExample:Form
    {
        public frmExecuteScalarExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecuteScalarExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecuteScalarExample";
            this.Text = "frmExecuteScalarExample";
            this.Load += new System.EventHandler(this.frmExecuteScalarExample_Load);
            this.ResumeLayout(false);

        }

        private void frmExecuteScalarExample_Load(object sender, EventArgs e)
        {

        }
    }
}
