using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0700__enum_base_type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Convertenumtoint.htm
    public partial  class frmConvertenumtoint:Form
    {
        public frmConvertenumtoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConvertenumtoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConvertenumtoint";
            this.Text = "frmConvertenumtoint";
            this.Load += new System.EventHandler(this.frmConvertenumtoint_Load);
            this.ResumeLayout(false);

        }

        private void frmConvertenumtoint_Load(object sender, EventArgs e)
        {

        }
    }
}
