using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0100__XmlReader
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XmlReaderSettingsandXmlWriterSettings.htm
    public partial  class frmXmlReaderSettingsandXmlWriterSettings:Form
    {
        public frmXmlReaderSettingsandXmlWriterSettings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXmlReaderSettingsandXmlWriterSettings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXmlReaderSettingsandXmlWriterSettings";
            this.Text = "frmXmlReaderSettingsandXmlWriterSettings";
            this.Load += new System.EventHandler(this.frmXmlReaderSettingsandXmlWriterSettings_Load);
            this.ResumeLayout(false);

        }

        private void frmXmlReaderSettingsandXmlWriterSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
