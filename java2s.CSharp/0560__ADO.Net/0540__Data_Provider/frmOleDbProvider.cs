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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OleDbProvider.htm
    public partial  class frmOleDbProvider:Form
    {
        public frmOleDbProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOleDbProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOleDbProvider";
            this.Text = "frmOleDbProvider";
            this.Load += new System.EventHandler(this.frmOleDbProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmOleDbProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
