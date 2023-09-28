using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0380__Base_class_constaint
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Asimpledemonstrationofabaseclassconstraint.htm
    public partial  class frmAsimpledemonstrationofabaseclassconstraint:Form
    {
        public frmAsimpledemonstrationofabaseclassconstraint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpledemonstrationofabaseclassconstraint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpledemonstrationofabaseclassconstraint";
            this.Text = "frmAsimpledemonstrationofabaseclassconstraint";
            this.Load += new System.EventHandler(this.frmAsimpledemonstrationofabaseclassconstraint_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpledemonstrationofabaseclassconstraint_Load(object sender, EventArgs e)
        {

        }
    }
}
