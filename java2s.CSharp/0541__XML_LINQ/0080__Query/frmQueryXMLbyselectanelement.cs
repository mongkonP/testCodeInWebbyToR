using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0080__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/QueryXMLbyselectanelement.htm
    public partial  class frmQueryXMLbyselectanelement:Form
    {
        public frmQueryXMLbyselectanelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryXMLbyselectanelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryXMLbyselectanelement";
            this.Text = "frmQueryXMLbyselectanelement";
            this.Load += new System.EventHandler(this.frmQueryXMLbyselectanelement_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryXMLbyselectanelement_Load(object sender, EventArgs e)
        {

        }
    }
}
