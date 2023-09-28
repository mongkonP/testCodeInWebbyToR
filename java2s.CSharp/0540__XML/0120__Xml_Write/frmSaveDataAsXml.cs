using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0120__Xml_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SaveDataAsXml.htm
    public partial  class frmSaveDataAsXml:Form
    {
        public frmSaveDataAsXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveDataAsXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveDataAsXml";
            this.Text = "frmSaveDataAsXml";
            this.Load += new System.EventHandler(this.frmSaveDataAsXml_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveDataAsXml_Load(object sender, EventArgs e)
        {

        }
    }
}
