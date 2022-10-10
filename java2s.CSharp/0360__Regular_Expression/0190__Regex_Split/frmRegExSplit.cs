using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0190__Regex_Split
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/RegExSplit.htm
    public partial  class frmRegExSplit:Form
    {
        public frmRegExSplit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegExSplit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegExSplit";
            this.Text = "frmRegExSplit";
            this.Load += new System.EventHandler(this.frmRegExSplit_Load);
            this.ResumeLayout(false);

        }

        private void frmRegExSplit_Load(object sender, EventArgs e)
        {

        }
    }
}
