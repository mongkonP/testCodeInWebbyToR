using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0120__Logical_Relational_Operators
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/RelationalOperators.htm
    public partial  class frmRelationalOperators:Form
    {
        public frmRelationalOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRelationalOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRelationalOperators";
            this.Text = "frmRelationalOperators";
            this.Load += new System.EventHandler(this.frmRelationalOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmRelationalOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
