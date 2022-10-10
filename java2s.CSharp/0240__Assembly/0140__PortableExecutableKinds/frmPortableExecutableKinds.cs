using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0140__PortableExecutableKinds
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/PortableExecutableKinds.htm
    public partial  class frmPortableExecutableKinds:Form
    {
        public frmPortableExecutableKinds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPortableExecutableKinds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPortableExecutableKinds";
            this.Text = "frmPortableExecutableKinds";
            this.Load += new System.EventHandler(this.frmPortableExecutableKinds_Load);
            this.ResumeLayout(false);

        }

        private void frmPortableExecutableKinds_Load(object sender, EventArgs e)
        {

        }
    }
}
