using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0220__SHA1Managed
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/ProduceaSHA1hash.htm
    public partial  class frmProduceaSHA1hash:Form
    {
        public frmProduceaSHA1hash()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProduceaSHA1hash
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProduceaSHA1hash";
            this.Text = "frmProduceaSHA1hash";
            this.Load += new System.EventHandler(this.frmProduceaSHA1hash_Load);
            this.ResumeLayout(false);

        }

        private void frmProduceaSHA1hash_Load(object sender, EventArgs e)
        {

        }
    }
}
