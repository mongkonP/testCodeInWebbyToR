using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0100__Attributes_Reflection
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/UsetheGetCustomAttributesmethod.htm
    public partial  class frmUsetheGetCustomAttributesmethod:Form
    {
        public frmUsetheGetCustomAttributesmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheGetCustomAttributesmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheGetCustomAttributesmethod";
            this.Text = "frmUsetheGetCustomAttributesmethod";
            this.Load += new System.EventHandler(this.frmUsetheGetCustomAttributesmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheGetCustomAttributesmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
