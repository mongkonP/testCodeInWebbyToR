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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usethreadlocalstorage.htm
    public partial  class frmUsethreadlocalstorage:Form
    {
        public frmUsethreadlocalstorage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethreadlocalstorage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethreadlocalstorage";
            this.Text = "frmUsethreadlocalstorage";
            this.Load += new System.EventHandler(this.frmUsethreadlocalstorage_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethreadlocalstorage_Load(object sender, EventArgs e)
        {

        }
    }
}
