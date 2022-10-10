using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0400__Class_hierarchy
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InheritedImplementation.htm
    public partial  class frmInheritedImplementation:Form
    {
        public frmInheritedImplementation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritedImplementation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritedImplementation";
            this.Text = "frmInheritedImplementation";
            this.Load += new System.EventHandler(this.frmInheritedImplementation_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritedImplementation_Load(object sender, EventArgs e)
        {

        }
    }
}
