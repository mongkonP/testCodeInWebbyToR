using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0180__Password
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Changepassword.htm
    public partial  class frmChangepassword:Form
    {
        public frmChangepassword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangepassword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangepassword";
            this.Text = "frmChangepassword";
            this.Load += new System.EventHandler(this.frmChangepassword_Load);
            this.ResumeLayout(false);

        }

        private void frmChangepassword_Load(object sender, EventArgs e)
        {

        }
    }
}
