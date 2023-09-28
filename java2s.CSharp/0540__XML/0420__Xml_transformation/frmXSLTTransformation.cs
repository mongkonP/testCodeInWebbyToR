using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0420__Xml_transformation
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XSLTTransformation.htm
    public partial  class frmXSLTTransformation:Form
    {
        public frmXSLTTransformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXSLTTransformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXSLTTransformation";
            this.Text = "frmXSLTTransformation";
            this.Load += new System.EventHandler(this.frmXSLTTransformation_Load);
            this.ResumeLayout(false);

        }

        private void frmXSLTTransformation_Load(object sender, EventArgs e)
        {

        }
    }
}
