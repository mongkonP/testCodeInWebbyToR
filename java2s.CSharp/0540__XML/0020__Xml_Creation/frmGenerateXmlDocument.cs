using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0020__Xml_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/GenerateXmlDocument.htm
    public partial  class frmGenerateXmlDocument:Form
    {
        public frmGenerateXmlDocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenerateXmlDocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenerateXmlDocument";
            this.Text = "frmGenerateXmlDocument";
            this.Load += new System.EventHandler(this.frmGenerateXmlDocument_Load);
            this.ResumeLayout(false);

        }

        private void frmGenerateXmlDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
