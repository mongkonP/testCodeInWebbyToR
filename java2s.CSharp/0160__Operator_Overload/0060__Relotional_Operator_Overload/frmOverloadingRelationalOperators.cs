using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0060__Relotional_Operator_Overload
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/OverloadingRelationalOperators.htm
    public partial  class frmOverloadingRelationalOperators:Form
    {
        public frmOverloadingRelationalOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadingRelationalOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadingRelationalOperators";
            this.Text = "frmOverloadingRelationalOperators";
            this.Load += new System.EventHandler(this.frmOverloadingRelationalOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadingRelationalOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
