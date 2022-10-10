using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0040__Obsolete_Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/UsingObsoleteAttribute.htm
    public partial  class frmUsingObsoleteAttribute:Form
    {
        public frmUsingObsoleteAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingObsoleteAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingObsoleteAttribute";
            this.Text = "frmUsingObsoleteAttribute";
            this.Load += new System.EventHandler(this.frmUsingObsoleteAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingObsoleteAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
