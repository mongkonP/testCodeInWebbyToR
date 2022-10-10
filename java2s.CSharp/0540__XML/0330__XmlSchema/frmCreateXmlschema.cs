using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0330__XmlSchema
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/CreateXmlschema.htm
    public partial  class frmCreateXmlschema:Form
    {
        public frmCreateXmlschema()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateXmlschema
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateXmlschema";
            this.Text = "frmCreateXmlschema";
            this.Load += new System.EventHandler(this.frmCreateXmlschema_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateXmlschema_Load(object sender, EventArgs e)
        {

        }
    }
}
