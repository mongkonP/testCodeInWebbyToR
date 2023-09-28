using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0360__GC
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Forcedgarbagecollection.htm
    public partial  class frmForcedgarbagecollection:Form
    {
        public frmForcedgarbagecollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmForcedgarbagecollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmForcedgarbagecollection";
            this.Text = "frmForcedgarbagecollection";
            this.Load += new System.EventHandler(this.frmForcedgarbagecollection_Load);
            this.ResumeLayout(false);

        }

        private void frmForcedgarbagecollection_Load(object sender, EventArgs e)
        {

        }
    }
}
