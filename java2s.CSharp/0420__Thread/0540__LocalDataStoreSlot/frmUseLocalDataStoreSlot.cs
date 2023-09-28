using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0540__LocalDataStoreSlot
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseLocalDataStoreSlot.htm
    public partial  class frmUseLocalDataStoreSlot:Form
    {
        public frmUseLocalDataStoreSlot()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLocalDataStoreSlot
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLocalDataStoreSlot";
            this.Text = "frmUseLocalDataStoreSlot";
            this.Load += new System.EventHandler(this.frmUseLocalDataStoreSlot_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLocalDataStoreSlot_Load(object sender, EventArgs e)
        {

        }
    }
}
