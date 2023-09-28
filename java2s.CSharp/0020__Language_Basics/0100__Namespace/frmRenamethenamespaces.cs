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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Renamethenamespaces.htm
    public partial  class frmRenamethenamespaces:Form
    {
        public frmRenamethenamespaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRenamethenamespaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRenamethenamespaces";
            this.Text = "frmRenamethenamespaces";
            this.Load += new System.EventHandler(this.frmRenamethenamespaces_Load);
            this.ResumeLayout(false);

        }

        private void frmRenamethenamespaces_Load(object sender, EventArgs e)
        {

        }
    }
}
