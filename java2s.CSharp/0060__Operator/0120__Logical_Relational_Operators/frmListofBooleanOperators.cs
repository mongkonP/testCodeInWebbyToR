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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/ListofBooleanOperators.htm
    public partial  class frmListofBooleanOperators:Form
    {
        public frmListofBooleanOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListofBooleanOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListofBooleanOperators";
            this.Text = "frmListofBooleanOperators";
            this.Load += new System.EventHandler(this.frmListofBooleanOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmListofBooleanOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
