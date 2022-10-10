using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0960__ToString
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/DemonstrateToString.htm
    public partial  class frmDemonstrateToString:Form
    {
        public frmDemonstrateToString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateToString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateToString";
            this.Text = "frmDemonstrateToString";
            this.Load += new System.EventHandler(this.frmDemonstrateToString_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateToString_Load(object sender, EventArgs e)
        {

        }
    }
}
