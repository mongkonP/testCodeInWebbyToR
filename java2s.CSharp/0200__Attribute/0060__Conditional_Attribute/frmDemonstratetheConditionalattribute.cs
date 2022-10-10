using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0060__Conditional_Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/DemonstratetheConditionalattribute.htm
    public partial  class frmDemonstratetheConditionalattribute:Form
    {
        public frmDemonstratetheConditionalattribute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheConditionalattribute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheConditionalattribute";
            this.Text = "frmDemonstratetheConditionalattribute";
            this.Load += new System.EventHandler(this.frmDemonstratetheConditionalattribute_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheConditionalattribute_Load(object sender, EventArgs e)
        {

        }
    }
}
