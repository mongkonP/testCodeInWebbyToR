using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0020__Bind
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Anonymousbind.htm
    public partial  class frmAnonymousbind:Form
    {
        public frmAnonymousbind()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousbind
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousbind";
            this.Text = "frmAnonymousbind";
            this.Load += new System.EventHandler(this.frmAnonymousbind_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousbind_Load(object sender, EventArgs e)
        {

        }
    }
}
