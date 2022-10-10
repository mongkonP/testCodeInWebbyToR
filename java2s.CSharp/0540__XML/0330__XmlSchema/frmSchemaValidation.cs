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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SchemaValidation.htm
    public partial  class frmSchemaValidation:Form
    {
        public frmSchemaValidation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSchemaValidation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSchemaValidation";
            this.Text = "frmSchemaValidation";
            this.Load += new System.EventHandler(this.frmSchemaValidation_Load);
            this.ResumeLayout(false);

        }

        private void frmSchemaValidation_Load(object sender, EventArgs e)
        {

        }
    }
}
