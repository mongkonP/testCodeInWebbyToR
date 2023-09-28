using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0100__Attributes_Reflection
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/RetrieveAttributebyusingreflection.htm
    public partial  class frmRetrieveAttributebyusingreflection:Form
    {
        public frmRetrieveAttributebyusingreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrieveAttributebyusingreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrieveAttributebyusingreflection";
            this.Text = "frmRetrieveAttributebyusingreflection";
            this.Load += new System.EventHandler(this.frmRetrieveAttributebyusingreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrieveAttributebyusingreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
