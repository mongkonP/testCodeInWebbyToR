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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/ThePrecedenceoftheCOperators.htm
    public partial  class frmThePrecedenceoftheCOperators:Form
    {
        public frmThePrecedenceoftheCOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThePrecedenceoftheCOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThePrecedenceoftheCOperators";
            this.Text = "frmThePrecedenceoftheCOperators";
            this.Load += new System.EventHandler(this.frmThePrecedenceoftheCOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmThePrecedenceoftheCOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
