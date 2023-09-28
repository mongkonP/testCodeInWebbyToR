using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0420__MutexSecurity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/MutexSecurityandMutexAccessRule.htm
    public partial  class frmMutexSecurityandMutexAccessRule:Form
    {
        public frmMutexSecurityandMutexAccessRule()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMutexSecurityandMutexAccessRule
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMutexSecurityandMutexAccessRule";
            this.Text = "frmMutexSecurityandMutexAccessRule";
            this.Load += new System.EventHandler(this.frmMutexSecurityandMutexAccessRule_Load);
            this.ResumeLayout(false);

        }

        private void frmMutexSecurityandMutexAccessRule_Load(object sender, EventArgs e)
        {

        }
    }
}
