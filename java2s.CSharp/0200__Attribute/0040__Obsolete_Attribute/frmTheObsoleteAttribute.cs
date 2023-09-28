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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/TheObsoleteAttribute.htm
    public partial  class frmTheObsoleteAttribute:Form
    {
        public frmTheObsoleteAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheObsoleteAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheObsoleteAttribute";
            this.Text = "frmTheObsoleteAttribute";
            this.Load += new System.EventHandler(this.frmTheObsoleteAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmTheObsoleteAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
