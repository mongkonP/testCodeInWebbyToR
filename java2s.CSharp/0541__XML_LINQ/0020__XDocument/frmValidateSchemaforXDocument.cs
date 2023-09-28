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
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/ValidateSchemaforXDocument.htm
    public partial  class frmValidateSchemaforXDocument:Form
    {
        public frmValidateSchemaforXDocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValidateSchemaforXDocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValidateSchemaforXDocument";
            this.Text = "frmValidateSchemaforXDocument";
            this.Load += new System.EventHandler(this.frmValidateSchemaforXDocument_Load);
            this.ResumeLayout(false);

        }

        private void frmValidateSchemaforXDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
