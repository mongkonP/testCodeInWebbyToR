using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0240__pipe_operator
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/Overload.htm
    public partial  class frmOverload:Form
    {
        public frmOverload()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverload
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverload";
            this.Text = "frmOverload";
            this.Load += new System.EventHandler(this.frmOverload_Load);
            this.ResumeLayout(false);

        }

        private void frmOverload_Load(object sender, EventArgs e)
        {

        }
    }
}
