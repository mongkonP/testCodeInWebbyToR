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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UsingaNamespaceDirective.htm
    public partial  class frmUsingaNamespaceDirective:Form
    {
        public frmUsingaNamespaceDirective()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingaNamespaceDirective
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingaNamespaceDirective";
            this.Text = "frmUsingaNamespaceDirective";
            this.Load += new System.EventHandler(this.frmUsingaNamespaceDirective_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingaNamespaceDirective_Load(object sender, EventArgs e)
        {

        }
    }
}
