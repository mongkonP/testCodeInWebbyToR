using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0480__Cookie
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ExamineCookies.htm
    public partial  class frmExamineCookies:Form
    {
        public frmExamineCookies()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExamineCookies
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExamineCookies";
            this.Text = "frmExamineCookies";
            this.Load += new System.EventHandler(this.frmExamineCookies_Load);
            this.ResumeLayout(false);

        }

        private void frmExamineCookies_Load(object sender, EventArgs e)
        {

        }
    }
}
