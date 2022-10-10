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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/AliasingNamespaceNames.htm
    public partial  class frmAliasingNamespaceNames:Form
    {
        public frmAliasingNamespaceNames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAliasingNamespaceNames
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAliasingNamespaceNames";
            this.Text = "frmAliasingNamespaceNames";
            this.Load += new System.EventHandler(this.frmAliasingNamespaceNames_Load);
            this.ResumeLayout(false);

        }

        private void frmAliasingNamespaceNames_Load(object sender, EventArgs e)
        {

        }
    }
}
