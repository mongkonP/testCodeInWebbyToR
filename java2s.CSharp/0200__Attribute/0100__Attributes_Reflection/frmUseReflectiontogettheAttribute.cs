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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/UseReflectiontogettheAttribute.htm
    public partial  class frmUseReflectiontogettheAttribute:Form
    {
        public frmUseReflectiontogettheAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseReflectiontogettheAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseReflectiontogettheAttribute";
            this.Text = "frmUseReflectiontogettheAttribute";
            this.Load += new System.EventHandler(this.frmUseReflectiontogettheAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmUseReflectiontogettheAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
