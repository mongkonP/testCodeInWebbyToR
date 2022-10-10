using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Dynamicassemblyintrospection.htm
    public partial  class frmDynamicassemblyintrospection:Form
    {
        public frmDynamicassemblyintrospection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicassemblyintrospection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicassemblyintrospection";
            this.Text = "frmDynamicassemblyintrospection";
            this.Load += new System.EventHandler(this.frmDynamicassemblyintrospection_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicassemblyintrospection_Load(object sender, EventArgs e)
        {

        }
    }
}
