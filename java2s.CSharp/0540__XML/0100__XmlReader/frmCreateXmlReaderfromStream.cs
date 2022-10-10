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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/CreateXmlReaderfromStream.htm
    public partial  class frmCreateXmlReaderfromStream:Form
    {
        public frmCreateXmlReaderfromStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateXmlReaderfromStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateXmlReaderfromStream";
            this.Text = "frmCreateXmlReaderfromStream";
            this.Load += new System.EventHandler(this.frmCreateXmlReaderfromStream_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateXmlReaderfromStream_Load(object sender, EventArgs e)
        {

        }
    }
}
