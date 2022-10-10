using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0020__Assignment_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/TheAssignmentOperator.htm
    public partial  class frmTheAssignmentOperator:Form
    {
        public frmTheAssignmentOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheAssignmentOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheAssignmentOperator";
            this.Text = "frmTheAssignmentOperator";
            this.Load += new System.EventHandler(this.frmTheAssignmentOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmTheAssignmentOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
