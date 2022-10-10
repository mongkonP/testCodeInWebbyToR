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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ToreadfromanXMLfile.htm
    public partial  class frmToreadfromanXMLfile:Form
    {
        public frmToreadfromanXMLfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToreadfromanXMLfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToreadfromanXMLfile";
            this.Text = "frmToreadfromanXMLfile";
            this.Load += new System.EventHandler(this.frmToreadfromanXMLfile_Load);
            this.ResumeLayout(false);

        }

        private void frmToreadfromanXMLfile_Load(object sender, EventArgs e)
        {

        }
    }
}
