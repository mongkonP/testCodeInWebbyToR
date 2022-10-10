using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0480__Xml_serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XMLSerializationSample.htm
    public partial  class frmXMLSerializationSample:Form
    {
        public frmXMLSerializationSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXMLSerializationSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXMLSerializationSample";
            this.Text = "frmXMLSerializationSample";
            this.Load += new System.EventHandler(this.frmXMLSerializationSample_Load);
            this.ResumeLayout(false);

        }

        private void frmXMLSerializationSample_Load(object sender, EventArgs e)
        {

        }
    }
}
