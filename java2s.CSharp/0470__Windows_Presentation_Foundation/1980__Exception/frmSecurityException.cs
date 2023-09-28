using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SecurityException.htm
    public partial  class frmSecurityException:Form
    {
        public frmSecurityException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecurityException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecurityException";
            this.Text = "frmSecurityException";
            this.Load += new System.EventHandler(this.frmSecurityException_Load);
            this.ResumeLayout(false);

        }

        private void frmSecurityException_Load(object sender, EventArgs e)
        {

        }
    }
}
