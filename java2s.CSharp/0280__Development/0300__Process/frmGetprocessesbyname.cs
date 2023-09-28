using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Getprocessesbyname.htm
    public partial  class frmGetprocessesbyname:Form
    {
        public frmGetprocessesbyname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetprocessesbyname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetprocessesbyname";
            this.Text = "frmGetprocessesbyname";
            this.Load += new System.EventHandler(this.frmGetprocessesbyname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetprocessesbyname_Load(object sender, EventArgs e)
        {

        }
    }
}
