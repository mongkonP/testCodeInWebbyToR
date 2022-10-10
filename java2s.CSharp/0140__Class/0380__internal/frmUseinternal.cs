using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0380__internal
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useinternal.htm
    public partial  class frmUseinternal:Form
    {
        public frmUseinternal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseinternal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseinternal";
            this.Text = "frmUseinternal";
            this.Load += new System.EventHandler(this.frmUseinternal_Load);
            this.ResumeLayout(false);

        }

        private void frmUseinternal_Load(object sender, EventArgs e)
        {

        }
    }
}
