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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadXMLfromURL.htm
    public partial  class frmReadXMLfromURL:Form
    {
        public frmReadXMLfromURL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadXMLfromURL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadXMLfromURL";
            this.Text = "frmReadXMLfromURL";
            this.Load += new System.EventHandler(this.frmReadXMLfromURL_Load);
            this.ResumeLayout(false);

        }

        private void frmReadXMLfromURL_Load(object sender, EventArgs e)
        {

        }
    }
}
