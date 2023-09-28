using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0340__SemaphoreSecurity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/WorkwithSemaphoreSecurity.htm
    public partial  class frmWorkwithSemaphoreSecurity:Form
    {
        public frmWorkwithSemaphoreSecurity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWorkwithSemaphoreSecurity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWorkwithSemaphoreSecurity";
            this.Text = "frmWorkwithSemaphoreSecurity";
            this.Load += new System.EventHandler(this.frmWorkwithSemaphoreSecurity_Load);
            this.ResumeLayout(false);

        }

        private void frmWorkwithSemaphoreSecurity_Load(object sender, EventArgs e)
        {

        }
    }
}
