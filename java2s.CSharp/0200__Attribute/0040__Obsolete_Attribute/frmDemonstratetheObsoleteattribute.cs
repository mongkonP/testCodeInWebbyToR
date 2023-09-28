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
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/DemonstratetheObsoleteattribute.htm
    public partial  class frmDemonstratetheObsoleteattribute:Form
    {
        public frmDemonstratetheObsoleteattribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheObsoleteattribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheObsoleteattribute";
            this.Text = "frmDemonstratetheObsoleteattribute";
            this.Load += new System.EventHandler(this.frmDemonstratetheObsoleteattribute_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheObsoleteattribute_Load(object sender, EventArgs e)
        {

        }
    }
}
