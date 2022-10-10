using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0200__Encoding_Unicode
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/Unicodeencode.htm
    public partial  class frmUnicodeencode:Form
    {
        public frmUnicodeencode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnicodeencode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnicodeencode";
            this.Text = "frmUnicodeencode";
            this.Load += new System.EventHandler(this.frmUnicodeencode_Load);
            this.ResumeLayout(false);

        }

        private void frmUnicodeencode_Load(object sender, EventArgs e)
        {

        }
    }
}
