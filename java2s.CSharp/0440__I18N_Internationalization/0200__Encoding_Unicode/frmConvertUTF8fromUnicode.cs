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
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/ConvertUTF8fromUnicode.htm
    public partial  class frmConvertUTF8fromUnicode:Form
    {
        public frmConvertUTF8fromUnicode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConvertUTF8fromUnicode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConvertUTF8fromUnicode";
            this.Text = "frmConvertUTF8fromUnicode";
            this.Load += new System.EventHandler(this.frmConvertUTF8fromUnicode_Load);
            this.ResumeLayout(false);

        }

        private void frmConvertUTF8fromUnicode_Load(object sender, EventArgs e)
        {

        }
    }
}
