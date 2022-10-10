using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0340__synchronized
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SyncDelegate.htm
    public partial  class frmSyncDelegate:Form
    {
        public frmSyncDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSyncDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSyncDelegate";
            this.Text = "frmSyncDelegate";
            this.Load += new System.EventHandler(this.frmSyncDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmSyncDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
