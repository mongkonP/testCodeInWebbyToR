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
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/QueryXMLAlldescendantsindocument.htm
    public partial  class frmQueryXMLAlldescendantsindocument:Form
    {
        public frmQueryXMLAlldescendantsindocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryXMLAlldescendantsindocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryXMLAlldescendantsindocument";
            this.Text = "frmQueryXMLAlldescendantsindocument";
            this.Load += new System.EventHandler(this.frmQueryXMLAlldescendantsindocument_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryXMLAlldescendantsindocument_Load(object sender, EventArgs e)
        {

        }
    }
}
