using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0160__RandomNumberGenerator
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Cryptographicallysoundrandomnumbers.htm
    public partial  class frmCryptographicallysoundrandomnumbers:Form
    {
        public frmCryptographicallysoundrandomnumbers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCryptographicallysoundrandomnumbers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCryptographicallysoundrandomnumbers";
            this.Text = "frmCryptographicallysoundrandomnumbers";
            this.Load += new System.EventHandler(this.frmCryptographicallysoundrandomnumbers_Load);
            this.ResumeLayout(false);

        }

        private void frmCryptographicallysoundrandomnumbers_Load(object sender, EventArgs e)
        {

        }
    }
}
