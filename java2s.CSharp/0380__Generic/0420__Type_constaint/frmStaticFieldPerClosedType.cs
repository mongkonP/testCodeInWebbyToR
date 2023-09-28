using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0420__Type_constaint
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/StaticFieldPerClosedType.htm
    public partial  class frmStaticFieldPerClosedType:Form
    {
        public frmStaticFieldPerClosedType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticFieldPerClosedType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticFieldPerClosedType";
            this.Text = "frmStaticFieldPerClosedType";
            this.Load += new System.EventHandler(this.frmStaticFieldPerClosedType_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticFieldPerClosedType_Load(object sender, EventArgs e)
        {

        }
    }
}
