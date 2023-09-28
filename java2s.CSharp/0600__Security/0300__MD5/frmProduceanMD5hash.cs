using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0300__MD5
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/ProduceanMD5hash.htm
    public partial  class frmProduceanMD5hash:Form
    {
        public frmProduceanMD5hash()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProduceanMD5hash
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProduceanMD5hash";
            this.Text = "frmProduceanMD5hash";
            this.Load += new System.EventHandler(this.frmProduceanMD5hash_Load);
            this.ResumeLayout(false);

        }

        private void frmProduceanMD5hash_Load(object sender, EventArgs e)
        {

        }
    }
}
