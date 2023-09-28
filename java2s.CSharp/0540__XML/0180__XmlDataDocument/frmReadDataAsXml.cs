using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0180__XmlDataDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadDataAsXml.htm
    public partial  class frmReadDataAsXml:Form
    {
        public frmReadDataAsXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadDataAsXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadDataAsXml";
            this.Text = "frmReadDataAsXml";
            this.Load += new System.EventHandler(this.frmReadDataAsXml_Load);
            this.ResumeLayout(false);

        }

        private void frmReadDataAsXml_Load(object sender, EventArgs e)
        {

        }
    }
}
