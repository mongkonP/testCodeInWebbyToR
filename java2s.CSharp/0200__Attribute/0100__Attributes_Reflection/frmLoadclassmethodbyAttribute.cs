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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/LoadclassmethodbyAttribute.htm
    public partial  class frmLoadclassmethodbyAttribute:Form
    {
        public frmLoadclassmethodbyAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadclassmethodbyAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadclassmethodbyAttribute";
            this.Text = "frmLoadclassmethodbyAttribute";
            this.Load += new System.EventHandler(this.frmLoadclassmethodbyAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadclassmethodbyAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
