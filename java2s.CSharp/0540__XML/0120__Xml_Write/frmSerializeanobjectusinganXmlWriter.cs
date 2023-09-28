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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SerializeanobjectusinganXmlWriter.htm
    public partial  class frmSerializeanobjectusinganXmlWriter:Form
    {
        public frmSerializeanobjectusinganXmlWriter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializeanobjectusinganXmlWriter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializeanobjectusinganXmlWriter";
            this.Text = "frmSerializeanobjectusinganXmlWriter";
            this.Load += new System.EventHandler(this.frmSerializeanobjectusinganXmlWriter_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializeanobjectusinganXmlWriter_Load(object sender, EventArgs e)
        {

        }
    }
}
