using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0320__Word
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/ModifyDocumentProperties.htm
    public partial  class frmModifyDocumentProperties:Form
    {
        public frmModifyDocumentProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyDocumentProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyDocumentProperties";
            this.Text = "frmModifyDocumentProperties";
            this.Load += new System.EventHandler(this.frmModifyDocumentProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyDocumentProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
