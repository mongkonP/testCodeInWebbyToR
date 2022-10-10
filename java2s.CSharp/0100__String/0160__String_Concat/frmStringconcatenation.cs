using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0160__String_Concat
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringconcatenation.htm
    public partial  class frmStringconcatenation:Form
    {
        public frmStringconcatenation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringconcatenation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringconcatenation";
            this.Text = "frmStringconcatenation";
            this.Load += new System.EventHandler(this.frmStringconcatenation_Load);
            this.ResumeLayout(false);

        }

        private void frmStringconcatenation_Load(object sender, EventArgs e)
        {

        }
    }
}
