using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0320__Xml_Validation
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/UsingValidationEventHandler.htm
    public partial  class frmUsingValidationEventHandler:Form
    {
        public frmUsingValidationEventHandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingValidationEventHandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingValidationEventHandler";
            this.Text = "frmUsingValidationEventHandler";
            this.Load += new System.EventHandler(this.frmUsingValidationEventHandler_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingValidationEventHandler_Load(object sender, EventArgs e)
        {

        }
    }
}
