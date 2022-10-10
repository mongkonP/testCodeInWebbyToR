using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0260__Unicode
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/UnicodeEncodingExample.htm
    public partial  class frmUnicodeEncodingExample:Form
    {
        public frmUnicodeEncodingExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnicodeEncodingExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnicodeEncodingExample";
            this.Text = "frmUnicodeEncodingExample";
            this.Load += new System.EventHandler(this.frmUnicodeEncodingExample_Load);
            this.ResumeLayout(false);

        }

        private void frmUnicodeEncodingExample_Load(object sender, EventArgs e)
        {

        }
    }
}
