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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Namespacewithdot.htm
    public partial  class frmNamespacewithdot:Form
    {
        public frmNamespacewithdot()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNamespacewithdot
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNamespacewithdot";
            this.Text = "frmNamespacewithdot";
            this.Load += new System.EventHandler(this.frmNamespacewithdot_Load);
            this.ResumeLayout(false);

        }

        private void frmNamespacewithdot_Load(object sender, EventArgs e)
        {

        }
    }
}
