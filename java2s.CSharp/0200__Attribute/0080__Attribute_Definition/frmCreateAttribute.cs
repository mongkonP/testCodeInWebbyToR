using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0080__Attribute_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/CreateAttribute.htm
    public partial  class frmCreateAttribute:Form
    {
        public frmCreateAttribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateAttribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateAttribute";
            this.Text = "frmCreateAttribute";
            this.Load += new System.EventHandler(this.frmCreateAttribute_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
