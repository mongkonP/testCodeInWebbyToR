using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0240__String_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringCopyTo.htm
    public partial  class frmStringCopyTo:Form
    {
        public frmStringCopyTo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringCopyTo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringCopyTo";
            this.Text = "frmStringCopyTo";
            this.Load += new System.EventHandler(this.frmStringCopyTo_Load);
            this.ResumeLayout(false);

        }

        private void frmStringCopyTo_Load(object sender, EventArgs e)
        {

        }
    }
}
