using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0320__Xml_Validation
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ValidateXml.htm
    public partial  class frmValidateXml:Form
    {
        public frmValidateXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValidateXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValidateXml";
            this.Text = "frmValidateXml";
            this.Load += new System.EventHandler(this.frmValidateXml_Load);
            this.ResumeLayout(false);

        }

        private void frmValidateXml_Load(object sender, EventArgs e)
        {

        }
    }
}
