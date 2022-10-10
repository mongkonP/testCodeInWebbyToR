using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0080__Xml_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SetupXmlReaderSettings.htm
    public partial  class frmSetupXmlReaderSettings:Form
    {
        public frmSetupXmlReaderSettings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetupXmlReaderSettings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetupXmlReaderSettings";
            this.Text = "frmSetupXmlReaderSettings";
            this.Load += new System.EventHandler(this.frmSetupXmlReaderSettings_Load);
            this.ResumeLayout(false);

        }

        private void frmSetupXmlReaderSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
