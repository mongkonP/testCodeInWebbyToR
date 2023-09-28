using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0060__Regex_Email
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/RegexforEmail.htm
    public partial  class frmRegexforEmail:Form
    {
        public frmRegexforEmail()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegexforEmail
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegexforEmail";
            this.Text = "frmRegexforEmail";
            this.Load += new System.EventHandler(this.frmRegexforEmail_Load);
            this.ResumeLayout(false);

        }

        private void frmRegexforEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
