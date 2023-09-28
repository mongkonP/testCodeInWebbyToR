using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0520__SqlTransaction
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/theuseofatransaction.htm
    public partial  class frmtheuseofatransaction:Form
    {
        public frmtheuseofatransaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmtheuseofatransaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmtheuseofatransaction";
            this.Text = "frmtheuseofatransaction";
            this.Load += new System.EventHandler(this.frmtheuseofatransaction_Load);
            this.ResumeLayout(false);

        }

        private void frmtheuseofatransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
