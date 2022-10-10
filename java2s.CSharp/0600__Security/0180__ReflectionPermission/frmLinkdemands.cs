using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0180__ReflectionPermission
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Linkdemands.htm
    public partial  class frmLinkdemands:Form
    {
        public frmLinkdemands()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinkdemands
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinkdemands";
            this.Text = "frmLinkdemands";
            this.Load += new System.EventHandler(this.frmLinkdemands_Load);
            this.ResumeLayout(false);

        }

        private void frmLinkdemands_Load(object sender, EventArgs e)
        {

        }
    }
}
