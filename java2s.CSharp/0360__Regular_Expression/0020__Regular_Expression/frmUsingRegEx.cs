using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0020__Regular_Expression
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/UsingRegEx.htm
    public partial  class frmUsingRegEx:Form
    {
        public frmUsingRegEx()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingRegEx
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingRegEx";
            this.Text = "frmUsingRegEx";
            this.Load += new System.EventHandler(this.frmUsingRegEx_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingRegEx_Load(object sender, EventArgs e)
        {

        }
    }
}
