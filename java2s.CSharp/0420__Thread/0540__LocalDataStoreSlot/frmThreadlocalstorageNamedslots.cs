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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadlocalstorageNamedslots.htm
    public partial  class frmThreadlocalstorageNamedslots:Form
    {
        public frmThreadlocalstorageNamedslots()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadlocalstorageNamedslots
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadlocalstorageNamedslots";
            this.Text = "frmThreadlocalstorageNamedslots";
            this.Load += new System.EventHandler(this.frmThreadlocalstorageNamedslots_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadlocalstorageNamedslots_Load(object sender, EventArgs e)
        {

        }
    }
}
