using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0040__XElement
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/XMLFragments.htm
    public partial  class frmXMLFragments:Form
    {
        public frmXMLFragments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXMLFragments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXMLFragments";
            this.Text = "frmXMLFragments";
            this.Load += new System.EventHandler(this.frmXMLFragments_Load);
            this.ResumeLayout(false);

        }

        private void frmXMLFragments_Load(object sender, EventArgs e)
        {

        }
    }
}
