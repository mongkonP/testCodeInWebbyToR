using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0020__XDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/LINQToXMLElementText.htm
    public partial  class frmLINQToXMLElementText:Form
    {
        public frmLINQToXMLElementText()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLINQToXMLElementText
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLINQToXMLElementText";
            this.Text = "frmLINQToXMLElementText";
            this.Load += new System.EventHandler(this.frmLINQToXMLElementText_Load);
            this.ResumeLayout(false);

        }

        private void frmLINQToXMLElementText_Load(object sender, EventArgs e)
        {

        }
    }
}
