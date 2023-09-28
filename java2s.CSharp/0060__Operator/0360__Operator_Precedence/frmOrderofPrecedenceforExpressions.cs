using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0360__Operator_Precedence
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/OrderofPrecedenceforExpressions.htm
    public partial  class frmOrderofPrecedenceforExpressions:Form
    {
        public frmOrderofPrecedenceforExpressions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderofPrecedenceforExpressions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderofPrecedenceforExpressions";
            this.Text = "frmOrderofPrecedenceforExpressions";
            this.Load += new System.EventHandler(this.frmOrderofPrecedenceforExpressions_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderofPrecedenceforExpressions_Load(object sender, EventArgs e)
        {

        }
    }
}
