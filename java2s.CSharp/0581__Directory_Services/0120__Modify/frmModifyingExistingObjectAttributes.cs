using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0120__Modify
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/ModifyingExistingObjectAttributes.htm
    public partial  class frmModifyingExistingObjectAttributes:Form
    {
        public frmModifyingExistingObjectAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyingExistingObjectAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyingExistingObjectAttributes";
            this.Text = "frmModifyingExistingObjectAttributes";
            this.Load += new System.EventHandler(this.frmModifyingExistingObjectAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyingExistingObjectAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
