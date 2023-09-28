using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ReferenceStaticFieldwithoutInstance.htm
    public partial  class frmReferenceStaticFieldwithoutInstance:Form
    {
        public frmReferenceStaticFieldwithoutInstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferenceStaticFieldwithoutInstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferenceStaticFieldwithoutInstance";
            this.Text = "frmReferenceStaticFieldwithoutInstance";
            this.Load += new System.EventHandler(this.frmReferenceStaticFieldwithoutInstance_Load);
            this.ResumeLayout(false);

        }

        private void frmReferenceStaticFieldwithoutInstance_Load(object sender, EventArgs e)
        {

        }
    }
}
