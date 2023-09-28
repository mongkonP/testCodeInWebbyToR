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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/TheBitwiseOperators.htm
    public partial  class frmTheBitwiseOperators:Form
    {
        public frmTheBitwiseOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheBitwiseOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheBitwiseOperators";
            this.Text = "frmTheBitwiseOperators";
            this.Load += new System.EventHandler(this.frmTheBitwiseOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmTheBitwiseOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
