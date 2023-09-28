using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0191__Regex_Replace
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/RegexReplace.htm
    public partial  class frmRegexReplace:Form
    {
        public frmRegexReplace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegexReplace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegexReplace";
            this.Text = "frmRegexReplace";
            this.Load += new System.EventHandler(this.frmRegexReplace_Load);
            this.ResumeLayout(false);

        }

        private void frmRegexReplace_Load(object sender, EventArgs e)
        {

        }
    }
}
