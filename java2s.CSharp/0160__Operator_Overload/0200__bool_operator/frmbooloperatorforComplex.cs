using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0200__bool_operator
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/booloperatorforComplex.htm
    public partial  class frmbooloperatorforComplex:Form
    {
        public frmbooloperatorforComplex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmbooloperatorforComplex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmbooloperatorforComplex";
            this.Text = "frmbooloperatorforComplex";
            this.Load += new System.EventHandler(this.frmbooloperatorforComplex_Load);
            this.ResumeLayout(false);

        }

        private void frmbooloperatorforComplex_Load(object sender, EventArgs e)
        {

        }
    }
}
