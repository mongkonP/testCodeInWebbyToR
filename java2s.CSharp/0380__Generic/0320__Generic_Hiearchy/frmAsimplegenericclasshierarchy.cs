using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0320__Generic_Hiearchy
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Asimplegenericclasshierarchy.htm
    public partial  class frmAsimplegenericclasshierarchy:Form
    {
        public frmAsimplegenericclasshierarchy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimplegenericclasshierarchy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimplegenericclasshierarchy";
            this.Text = "frmAsimplegenericclasshierarchy";
            this.Load += new System.EventHandler(this.frmAsimplegenericclasshierarchy_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimplegenericclasshierarchy_Load(object sender, EventArgs e)
        {

        }
    }
}
