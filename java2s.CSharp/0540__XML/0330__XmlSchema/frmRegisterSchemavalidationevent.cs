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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/RegisterSchemavalidationevent.htm
    public partial  class frmRegisterSchemavalidationevent:Form
    {
        public frmRegisterSchemavalidationevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegisterSchemavalidationevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegisterSchemavalidationevent";
            this.Text = "frmRegisterSchemavalidationevent";
            this.Load += new System.EventHandler(this.frmRegisterSchemavalidationevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRegisterSchemavalidationevent_Load(object sender, EventArgs e)
        {

        }
    }
}
