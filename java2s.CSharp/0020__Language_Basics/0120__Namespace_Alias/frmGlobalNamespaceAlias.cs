using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0120__Namespace_Alias
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/GlobalNamespaceAlias.htm
    public partial  class frmGlobalNamespaceAlias:Form
    {
        public frmGlobalNamespaceAlias()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGlobalNamespaceAlias
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGlobalNamespaceAlias";
            this.Text = "frmGlobalNamespaceAlias";
            this.Load += new System.EventHandler(this.frmGlobalNamespaceAlias_Load);
            this.ResumeLayout(false);

        }

        private void frmGlobalNamespaceAlias_Load(object sender, EventArgs e)
        {

        }
    }
}
