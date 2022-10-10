using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0040__DNS
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetIPHostEntrybyhostname.htm
    public partial  class frmGetIPHostEntrybyhostname:Form
    {
        public frmGetIPHostEntrybyhostname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetIPHostEntrybyhostname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetIPHostEntrybyhostname";
            this.Text = "frmGetIPHostEntrybyhostname";
            this.Load += new System.EventHandler(this.frmGetIPHostEntrybyhostname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetIPHostEntrybyhostname_Load(object sender, EventArgs e)
        {

        }
    }
}
