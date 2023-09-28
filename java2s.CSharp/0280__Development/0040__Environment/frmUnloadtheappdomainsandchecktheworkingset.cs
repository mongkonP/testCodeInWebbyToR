using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Unloadtheappdomainsandchecktheworkingset.htm
    public partial  class frmUnloadtheappdomainsandchecktheworkingset:Form
    {
        public frmUnloadtheappdomainsandchecktheworkingset()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnloadtheappdomainsandchecktheworkingset
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnloadtheappdomainsandchecktheworkingset";
            this.Text = "frmUnloadtheappdomainsandchecktheworkingset";
            this.Load += new System.EventHandler(this.frmUnloadtheappdomainsandchecktheworkingset_Load);
            this.ResumeLayout(false);

        }

        private void frmUnloadtheappdomainsandchecktheworkingset_Load(object sender, EventArgs e)
        {

        }
    }
}
