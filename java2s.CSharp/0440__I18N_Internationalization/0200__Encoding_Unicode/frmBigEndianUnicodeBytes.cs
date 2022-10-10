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
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/BigEndianUnicodeBytes.htm
    public partial  class frmBigEndianUnicodeBytes:Form
    {
        public frmBigEndianUnicodeBytes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBigEndianUnicodeBytes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBigEndianUnicodeBytes";
            this.Text = "frmBigEndianUnicodeBytes";
            this.Load += new System.EventHandler(this.frmBigEndianUnicodeBytes_Load);
            this.ResumeLayout(false);

        }

        private void frmBigEndianUnicodeBytes_Load(object sender, EventArgs e)
        {

        }
    }
}
