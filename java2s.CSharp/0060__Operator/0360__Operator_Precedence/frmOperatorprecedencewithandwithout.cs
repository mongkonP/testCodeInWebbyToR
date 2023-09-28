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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Operatorprecedencewithandwithout.htm
    public partial  class frmOperatorprecedencewithandwithout:Form
    {
        public frmOperatorprecedencewithandwithout()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOperatorprecedencewithandwithout
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOperatorprecedencewithandwithout";
            this.Text = "frmOperatorprecedencewithandwithout";
            this.Load += new System.EventHandler(this.frmOperatorprecedencewithandwithout_Load);
            this.ResumeLayout(false);

        }

        private void frmOperatorprecedencewithandwithout_Load(object sender, EventArgs e)
        {

        }
    }
}
