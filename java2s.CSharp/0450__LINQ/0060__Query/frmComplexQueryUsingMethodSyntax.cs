using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0060__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ComplexQueryUsingMethodSyntax.htm
    public partial  class frmComplexQueryUsingMethodSyntax:Form
    {
        public frmComplexQueryUsingMethodSyntax()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComplexQueryUsingMethodSyntax
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComplexQueryUsingMethodSyntax";
            this.Text = "frmComplexQueryUsingMethodSyntax";
            this.Load += new System.EventHandler(this.frmComplexQueryUsingMethodSyntax_Load);
            this.ResumeLayout(false);

        }

        private void frmComplexQueryUsingMethodSyntax_Load(object sender, EventArgs e)
        {

        }
    }
}
