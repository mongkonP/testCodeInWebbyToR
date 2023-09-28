using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0200__shift_operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/ShiftOperatorsinaction.htm
    public partial  class frmShiftOperatorsinaction:Form
    {
        public frmShiftOperatorsinaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShiftOperatorsinaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShiftOperatorsinaction";
            this.Text = "frmShiftOperatorsinaction";
            this.Load += new System.EventHandler(this.frmShiftOperatorsinaction_Load);
            this.ResumeLayout(false);

        }

        private void frmShiftOperatorsinaction_Load(object sender, EventArgs e)
        {

        }
    }
}
