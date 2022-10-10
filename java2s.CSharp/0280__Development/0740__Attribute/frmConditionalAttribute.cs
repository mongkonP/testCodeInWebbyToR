using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0740__Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ConditionalAttribute.htm
    public partial  class frmConditionalAttribute:Form
    {
        public frmConditionalAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConditionalAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConditionalAttribute";
            this.Text = "frmConditionalAttribute";
            this.Load += new System.EventHandler(this.frmConditionalAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmConditionalAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
