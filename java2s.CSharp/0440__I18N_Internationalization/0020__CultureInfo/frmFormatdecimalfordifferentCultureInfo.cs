using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0020__CultureInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/FormatdecimalfordifferentCultureInfo.htm
    public partial  class frmFormatdecimalfordifferentCultureInfo:Form
    {
        public frmFormatdecimalfordifferentCultureInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatdecimalfordifferentCultureInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatdecimalfordifferentCultureInfo";
            this.Text = "frmFormatdecimalfordifferentCultureInfo";
            this.Load += new System.EventHandler(this.frmFormatdecimalfordifferentCultureInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatdecimalfordifferentCultureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
