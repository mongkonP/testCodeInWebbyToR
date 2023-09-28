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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/AssemblyLevelAttributes.htm
    public partial  class frmAssemblyLevelAttributes:Form
    {
        public frmAssemblyLevelAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyLevelAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyLevelAttributes";
            this.Text = "frmAssemblyLevelAttributes";
            this.Load += new System.EventHandler(this.frmAssemblyLevelAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyLevelAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
