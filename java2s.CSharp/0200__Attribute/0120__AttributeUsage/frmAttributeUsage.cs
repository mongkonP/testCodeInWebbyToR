using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0120__AttributeUsage
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/AttributeUsage.htm
    public partial  class frmAttributeUsage:Form
    {
        public frmAttributeUsage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAttributeUsage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAttributeUsage";
            this.Text = "frmAttributeUsage";
            this.Load += new System.EventHandler(this.frmAttributeUsage_Load);
            this.ResumeLayout(false);

        }

        private void frmAttributeUsage_Load(object sender, EventArgs e)
        {

        }
    }
}
