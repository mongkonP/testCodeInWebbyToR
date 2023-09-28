using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0400__new_constaint
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Demonstrateanewconstructorconstraint.htm
    public partial  class frmDemonstrateanewconstructorconstraint:Form
    {
        public frmDemonstrateanewconstructorconstraint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateanewconstructorconstraint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateanewconstructorconstraint";
            this.Text = "frmDemonstrateanewconstructorconstraint";
            this.Load += new System.EventHandler(this.frmDemonstrateanewconstructorconstraint_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateanewconstructorconstraint_Load(object sender, EventArgs e)
        {

        }
    }
}
