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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/SimpleAliasesfornamespace.htm
    public partial  class frmSimpleAliasesfornamespace:Form
    {
        public frmSimpleAliasesfornamespace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleAliasesfornamespace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleAliasesfornamespace";
            this.Text = "frmSimpleAliasesfornamespace";
            this.Load += new System.EventHandler(this.frmSimpleAliasesfornamespace_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleAliasesfornamespace_Load(object sender, EventArgs e)
        {

        }
    }
}
