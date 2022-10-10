using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Aneventmulticastdemonstration.htm
    public partial  class frmAneventmulticastdemonstration:Form
    {
        public frmAneventmulticastdemonstration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAneventmulticastdemonstration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAneventmulticastdemonstration";
            this.Text = "frmAneventmulticastdemonstration";
            this.Load += new System.EventHandler(this.frmAneventmulticastdemonstration_Load);
            this.ResumeLayout(false);

        }

        private void frmAneventmulticastdemonstration_Load(object sender, EventArgs e)
        {

        }
    }
}
