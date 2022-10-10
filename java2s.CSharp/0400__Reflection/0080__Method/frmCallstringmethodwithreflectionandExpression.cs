using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/CallstringmethodwithreflectionandExpression.htm
    public partial  class frmCallstringmethodwithreflectionandExpression:Form
    {
        public frmCallstringmethodwithreflectionandExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallstringmethodwithreflectionandExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallstringmethodwithreflectionandExpression";
            this.Text = "frmCallstringmethodwithreflectionandExpression";
            this.Load += new System.EventHandler(this.frmCallstringmethodwithreflectionandExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmCallstringmethodwithreflectionandExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
