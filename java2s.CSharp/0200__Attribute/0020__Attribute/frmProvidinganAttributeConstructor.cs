using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0020__Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/ProvidinganAttributeConstructor.htm
    public partial  class frmProvidinganAttributeConstructor:Form
    {
        public frmProvidinganAttributeConstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProvidinganAttributeConstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProvidinganAttributeConstructor";
            this.Text = "frmProvidinganAttributeConstructor";
            this.Load += new System.EventHandler(this.frmProvidinganAttributeConstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmProvidinganAttributeConstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
