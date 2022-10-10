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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/ListofCompoundOperators.htm
    public partial  class frmListofCompoundOperators:Form
    {
        public frmListofCompoundOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListofCompoundOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListofCompoundOperators";
            this.Text = "frmListofCompoundOperators";
            this.Load += new System.EventHandler(this.frmListofCompoundOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmListofCompoundOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
