using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0140__public_field
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Publicstructmembervariables.htm
    public partial  class frmPublicstructmembervariables:Form
    {
        public frmPublicstructmembervariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPublicstructmembervariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPublicstructmembervariables";
            this.Text = "frmPublicstructmembervariables";
            this.Load += new System.EventHandler(this.frmPublicstructmembervariables_Load);
            this.ResumeLayout(false);

        }

        private void frmPublicstructmembervariables_Load(object sender, EventArgs e)
        {

        }
    }
}
