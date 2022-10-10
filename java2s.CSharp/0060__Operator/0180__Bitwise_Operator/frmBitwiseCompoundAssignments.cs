using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0180__Bitwise_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/BitwiseCompoundAssignments.htm
    public partial  class frmBitwiseCompoundAssignments:Form
    {
        public frmBitwiseCompoundAssignments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBitwiseCompoundAssignments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBitwiseCompoundAssignments";
            this.Text = "frmBitwiseCompoundAssignments";
            this.Load += new System.EventHandler(this.frmBitwiseCompoundAssignments_Load);
            this.ResumeLayout(false);

        }

        private void frmBitwiseCompoundAssignments_Load(object sender, EventArgs e)
        {

        }
    }
}
