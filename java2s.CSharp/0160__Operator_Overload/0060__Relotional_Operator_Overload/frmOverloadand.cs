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
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/Overloadand.htm
    public partial  class frmOverloadand:Form
    {
        public frmOverloadand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadand";
            this.Text = "frmOverloadand";
            this.Load += new System.EventHandler(this.frmOverloadand_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadand_Load(object sender, EventArgs e)
        {

        }
    }
}
