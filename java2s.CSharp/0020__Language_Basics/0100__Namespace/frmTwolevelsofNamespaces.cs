using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TwolevelsofNamespaces.htm
    public partial  class frmTwolevelsofNamespaces:Form
    {
        public frmTwolevelsofNamespaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTwolevelsofNamespaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTwolevelsofNamespaces";
            this.Text = "frmTwolevelsofNamespaces";
            this.Load += new System.EventHandler(this.frmTwolevelsofNamespaces_Load);
            this.ResumeLayout(false);

        }

        private void frmTwolevelsofNamespaces_Load(object sender, EventArgs e)
        {

        }
    }
}
