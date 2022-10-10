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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/CustomAttributes.htm
    public partial  class frmCustomAttributes:Form
    {
        public frmCustomAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomAttributes";
            this.Text = "frmCustomAttributes";
            this.Load += new System.EventHandler(this.frmCustomAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
