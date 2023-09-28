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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/NamespaceIntroduction.htm
    public partial  class frmNamespaceIntroduction:Form
    {
        public frmNamespaceIntroduction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNamespaceIntroduction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNamespaceIntroduction";
            this.Text = "frmNamespaceIntroduction";
            this.Load += new System.EventHandler(this.frmNamespaceIntroduction_Load);
            this.ResumeLayout(false);

        }

        private void frmNamespaceIntroduction_Load(object sender, EventArgs e)
        {

        }
    }
}
