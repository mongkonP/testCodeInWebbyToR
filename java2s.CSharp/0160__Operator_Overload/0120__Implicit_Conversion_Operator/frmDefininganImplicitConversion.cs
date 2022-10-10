using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0120__Implicit_Conversion_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/DefininganImplicitConversion.htm
    public partial  class frmDefininganImplicitConversion:Form
    {
        public frmDefininganImplicitConversion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefininganImplicitConversion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefininganImplicitConversion";
            this.Text = "frmDefininganImplicitConversion";
            this.Load += new System.EventHandler(this.frmDefininganImplicitConversion_Load);
            this.ResumeLayout(false);

        }

        private void frmDefininganImplicitConversion_Load(object sender, EventArgs e)
        {

        }
    }
}
