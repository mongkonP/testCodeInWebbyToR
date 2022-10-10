using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0200__String_Compare
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringequality.htm
    public partial  class frmStringequality:Form
    {
        public frmStringequality()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringequality
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringequality";
            this.Text = "frmStringequality";
            this.Load += new System.EventHandler(this.frmStringequality_Load);
            this.ResumeLayout(false);

        }

        private void frmStringequality_Load(object sender, EventArgs e)
        {

        }
    }
}
