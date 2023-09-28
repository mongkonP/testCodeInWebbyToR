using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0060__Uri
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseUri.htm
    public partial  class frmUseUri:Form
    {
        public frmUseUri()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseUri
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseUri";
            this.Text = "frmUseUri";
            this.Load += new System.EventHandler(this.frmUseUri_Load);
            this.ResumeLayout(false);

        }

        private void frmUseUri_Load(object sender, EventArgs e)
        {

        }
    }
}
